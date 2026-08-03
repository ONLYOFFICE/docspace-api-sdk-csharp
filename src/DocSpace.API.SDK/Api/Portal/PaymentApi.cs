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
namespace DocSpace.API.SDK.Api.Portal
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPaymentApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Calculate the wallet payment amount
        /// </summary>
        /// <remarks>
        /// Calculates an amount of the wallet payment with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The request parameters for specifying wallet payment quantity. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/calculate-wallet-payment/">REST API Reference for CalculateWalletPayment Operation</seealso>
        /// <returns>PaymentCalculationWrapper</returns>
        PaymentCalculationWrapper CalculateWalletPayment(WalletQuantityRequestDto? walletQuantityRequestDto = default);

        /// <summary>
        /// Calculate the wallet payment amount
        /// </summary>
        /// <remarks>
        /// Calculates an amount of the wallet payment with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The request parameters for specifying wallet payment quantity. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/calculate-wallet-payment/">REST API Reference for CalculateWalletPayment Operation</seealso>
        /// <returns>ApiResponse of PaymentCalculationWrapper</returns>
        ApiResponse<PaymentCalculationWrapper> CalculateWalletPaymentWithHttpInfo(WalletQuantityRequestDto? walletQuantityRequestDto = default);
        /// <summary>
        /// Change tenant wallet service state
        /// </summary>
        /// <remarks>
        /// Changes the state of a wallet service for the current tenant.  Requires permission to edit portal settings and a configured tariff service.  Adds or removes the specified service from the enabled services list based on the enabled flag.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="changeWalletServiceStateRequestDto">The request parameters for changing the tenant wallet service state. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-tenant-wallet-service-state/">REST API Reference for ChangeTenantWalletServiceState Operation</seealso>
        /// <returns>TenantWalletServiceSettingsWrapper</returns>
        TenantWalletServiceSettingsWrapper ChangeTenantWalletServiceState(ChangeWalletServiceStateRequestDto? changeWalletServiceStateRequestDto = default);

        /// <summary>
        /// Change tenant wallet service state
        /// </summary>
        /// <remarks>
        /// Changes the state of a wallet service for the current tenant.  Requires permission to edit portal settings and a configured tariff service.  Adds or removes the specified service from the enabled services list based on the enabled flag.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="changeWalletServiceStateRequestDto">The request parameters for changing the tenant wallet service state. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-tenant-wallet-service-state/">REST API Reference for ChangeTenantWalletServiceState Operation</seealso>
        /// <returns>ApiResponse of TenantWalletServiceSettingsWrapper</returns>
        ApiResponse<TenantWalletServiceSettingsWrapper> ChangeTenantWalletServiceStateWithHttpInfo(ChangeWalletServiceStateRequestDto? changeWalletServiceStateRequestDto = default);
        /// <summary>
        /// Start the customer monthly usage report generation
        /// </summary>
        /// <remarks>
        /// Starts generating a customer monthly usage report as an xlsx file and saves it in Documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerMonthlyUsageReportRequestDto">The request parameters for generating a customer monthly usage report. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-monthly-usage-report/">REST API Reference for CreateCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>DocumentBuilderTaskWrapper</returns>
        DocumentBuilderTaskWrapper CreateCustomerMonthlyUsageReport(CustomerMonthlyUsageReportRequestDto? customerMonthlyUsageReportRequestDto = default);

        /// <summary>
        /// Start the customer monthly usage report generation
        /// </summary>
        /// <remarks>
        /// Starts generating a customer monthly usage report as an xlsx file and saves it in Documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerMonthlyUsageReportRequestDto">The request parameters for generating a customer monthly usage report. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-monthly-usage-report/">REST API Reference for CreateCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>ApiResponse of DocumentBuilderTaskWrapper</returns>
        ApiResponse<DocumentBuilderTaskWrapper> CreateCustomerMonthlyUsageReportWithHttpInfo(CustomerMonthlyUsageReportRequestDto? customerMonthlyUsageReportRequestDto = default);
        /// <summary>
        /// Start the customer operations report generation
        /// </summary>
        /// <remarks>
        /// Starts generating a customer operations report as an xlsx file and saves it in Documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerOperationsReportRequestDto">The request parameters for generating a report on client operations. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-operations-report/">REST API Reference for CreateCustomerOperationsReport Operation</seealso>
        /// <returns>DocumentBuilderTaskWrapper</returns>
        DocumentBuilderTaskWrapper CreateCustomerOperationsReport(CustomerOperationsReportRequestDto? customerOperationsReportRequestDto = default);

        /// <summary>
        /// Start the customer operations report generation
        /// </summary>
        /// <remarks>
        /// Starts generating a customer operations report as an xlsx file and saves it in Documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerOperationsReportRequestDto">The request parameters for generating a report on client operations. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-operations-report/">REST API Reference for CreateCustomerOperationsReport Operation</seealso>
        /// <returns>ApiResponse of DocumentBuilderTaskWrapper</returns>
        ApiResponse<DocumentBuilderTaskWrapper> CreateCustomerOperationsReportWithHttpInfo(CustomerOperationsReportRequestDto? customerOperationsReportRequestDto = default);
        /// <summary>
        /// Start the customer service usage report generation
        /// </summary>
        /// <remarks>
        /// Starts generating a customer service usage report as an xlsx file and saves it in Documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerServiceUsageReportRequestDto">The request parameters for generating a customer service usage report. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-service-usage-report/">REST API Reference for CreateCustomerServiceUsageReport Operation</seealso>
        /// <returns>DocumentBuilderTaskWrapper</returns>
        DocumentBuilderTaskWrapper CreateCustomerServiceUsageReport(CustomerServiceUsageReportRequestDto? customerServiceUsageReportRequestDto = default);

        /// <summary>
        /// Start the customer service usage report generation
        /// </summary>
        /// <remarks>
        /// Starts generating a customer service usage report as an xlsx file and saves it in Documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerServiceUsageReportRequestDto">The request parameters for generating a customer service usage report. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-service-usage-report/">REST API Reference for CreateCustomerServiceUsageReport Operation</seealso>
        /// <returns>ApiResponse of DocumentBuilderTaskWrapper</returns>
        ApiResponse<DocumentBuilderTaskWrapper> CreateCustomerServiceUsageReportWithHttpInfo(CustomerServiceUsageReportRequestDto? customerServiceUsageReportRequestDto = default);
        /// <summary>
        /// Credit AI balance
        /// </summary>
        /// <remarks>
        /// Credits AI quota to the customer AI sub-account from their main balance.  Requires the customer to have a configured payment method.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="creditAiBalanceRequestDto">The request parameters for crediting AI quota to the customer AI subaccount. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/credit-ai-balance/">REST API Reference for CreditAiBalance Operation</seealso>
        /// <returns>ServicePaymentWrapper</returns>
        ServicePaymentWrapper CreditAiBalance(CreditAiBalanceRequestDto? creditAiBalanceRequestDto = default);

        /// <summary>
        /// Credit AI balance
        /// </summary>
        /// <remarks>
        /// Credits AI quota to the customer AI sub-account from their main balance.  Requires the customer to have a configured payment method.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="creditAiBalanceRequestDto">The request parameters for crediting AI quota to the customer AI subaccount. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/credit-ai-balance/">REST API Reference for CreditAiBalance Operation</seealso>
        /// <returns>ApiResponse of ServicePaymentWrapper</returns>
        ApiResponse<ServicePaymentWrapper> CreditAiBalanceWithHttpInfo(CreditAiBalanceRequestDto? creditAiBalanceRequestDto = default);
        /// <summary>
        /// Get AI model prices
        /// </summary>
        /// <remarks>
        /// Retrieves the pricing information for AI models including chat, embedding, and web search services.  The prices are returned in the configured currency and normalized per million tokens.  Requires administrator permissions to access.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-ai-prices/">REST API Reference for GetAiPrices Operation</seealso>
        /// <returns>AiPricesResponseWrapper</returns>
        AiPricesResponseWrapper GetAiPrices();

        /// <summary>
        /// Get AI model prices
        /// </summary>
        /// <remarks>
        /// Retrieves the pricing information for AI models including chat, embedding, and web search services.  The prices are returned in the configured currency and normalized per million tokens.  Requires administrator permissions to access.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-ai-prices/">REST API Reference for GetAiPrices Operation</seealso>
        /// <returns>ApiResponse of AiPricesResponseWrapper</returns>
        ApiResponse<AiPricesResponseWrapper> GetAiPricesWithHttpInfo();
        /// <summary>
        /// Get the checkout setup page URL
        /// </summary>
        /// <remarks>
        /// Returns the URL to the checkout setup page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">The URL where the user will be redirected after setup cancellation.</param>
        /// <param name="successUrl">The URL where the user will be redirected after successful payment.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-checkout-setup-url/">REST API Reference for GetCheckoutSetupUrl Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper GetCheckoutSetupUrl(string backUrl, string successUrl);

        /// <summary>
        /// Get the checkout setup page URL
        /// </summary>
        /// <remarks>
        /// Returns the URL to the checkout setup page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">The URL where the user will be redirected after setup cancellation.</param>
        /// <param name="successUrl">The URL where the user will be redirected after successful payment.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-checkout-setup-url/">REST API Reference for GetCheckoutSetupUrl Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> GetCheckoutSetupUrlWithHttpInfo(string backUrl, string successUrl);
        /// <summary>
        /// Get the customer AI balance
        /// </summary>
        /// <remarks>
        /// Returns the AI quota balance of a customer from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-ai-balance/">REST API Reference for GetCustomerAiBalance Operation</seealso>
        /// <returns>BalanceWrapper</returns>
        BalanceWrapper GetCustomerAiBalance(bool? refresh = default);

        /// <summary>
        /// Get the customer AI balance
        /// </summary>
        /// <remarks>
        /// Returns the AI quota balance of a customer from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-ai-balance/">REST API Reference for GetCustomerAiBalance Operation</seealso>
        /// <returns>ApiResponse of BalanceWrapper</returns>
        ApiResponse<BalanceWrapper> GetCustomerAiBalanceWithHttpInfo(bool? refresh = default);
        /// <summary>
        /// Get the customer balance
        /// </summary>
        /// <remarks>
        /// Returns the customer balance from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-balance/">REST API Reference for GetCustomerBalance Operation</seealso>
        /// <returns>BalanceWrapper</returns>
        BalanceWrapper GetCustomerBalance(bool? refresh = default);

        /// <summary>
        /// Get the customer balance
        /// </summary>
        /// <remarks>
        /// Returns the customer balance from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-balance/">REST API Reference for GetCustomerBalance Operation</seealso>
        /// <returns>ApiResponse of BalanceWrapper</returns>
        ApiResponse<BalanceWrapper> GetCustomerBalanceWithHttpInfo(bool? refresh = default);
        /// <summary>
        /// Get the customer information
        /// </summary>
        /// <remarks>
        /// Returns the customer information.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-info/">REST API Reference for GetCustomerInfo Operation</seealso>
        /// <returns>CustomerInfoWrapper</returns>
        CustomerInfoWrapper GetCustomerInfo(bool? refresh = default);

        /// <summary>
        /// Get the customer information
        /// </summary>
        /// <remarks>
        /// Returns the customer information.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-info/">REST API Reference for GetCustomerInfo Operation</seealso>
        /// <returns>ApiResponse of CustomerInfoWrapper</returns>
        ApiResponse<CustomerInfoWrapper> GetCustomerInfoWithHttpInfo(bool? refresh = default);
        /// <summary>
        /// Get the customer monthly usage
        /// </summary>
        /// <remarks>
        /// Returns the customer spending aggregated per calendar month from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Start of the period (inclusive). (optional)</param>
        /// <param name="endDate">End of the period (inclusive). (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-monthly-usage/">REST API Reference for GetCustomerMonthlyUsage Operation</seealso>
        /// <returns>CustomerMonthlyUsageArrayWrapper</returns>
        CustomerMonthlyUsageArrayWrapper GetCustomerMonthlyUsage(DateTime? startDate = default, DateTime? endDate = default);

        /// <summary>
        /// Get the customer monthly usage
        /// </summary>
        /// <remarks>
        /// Returns the customer spending aggregated per calendar month from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Start of the period (inclusive). (optional)</param>
        /// <param name="endDate">End of the period (inclusive). (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-monthly-usage/">REST API Reference for GetCustomerMonthlyUsage Operation</seealso>
        /// <returns>ApiResponse of CustomerMonthlyUsageArrayWrapper</returns>
        ApiResponse<CustomerMonthlyUsageArrayWrapper> GetCustomerMonthlyUsageWithHttpInfo(DateTime? startDate = default, DateTime? endDate = default);
        /// <summary>
        /// Get the status of the customer monthly usage report generation
        /// </summary>
        /// <remarks>
        /// Returns the status of generating a customer monthly usage report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-monthly-usage-report/">REST API Reference for GetCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>DocumentBuilderTaskWrapper</returns>
        DocumentBuilderTaskWrapper GetCustomerMonthlyUsageReport();

        /// <summary>
        /// Get the status of the customer monthly usage report generation
        /// </summary>
        /// <remarks>
        /// Returns the status of generating a customer monthly usage report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-monthly-usage-report/">REST API Reference for GetCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>ApiResponse of DocumentBuilderTaskWrapper</returns>
        ApiResponse<DocumentBuilderTaskWrapper> GetCustomerMonthlyUsageReportWithHttpInfo();
        /// <summary>
        /// Get the customer operations
        /// </summary>
        /// <remarks>
        /// Returns the report of customer operations from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">The number of items to skip for pagination. The default value is 0. (optional)</param>
        /// <param name="limit">The maximum number of items to return for pagination. The default value is 25. (optional)</param>
        /// <param name="serviceName">The service name list. A single string is also accepted for backward compatibility. (optional)</param>
        /// <param name="startDate">The report start date. (optional)</param>
        /// <param name="endDate">The report end date. (optional)</param>
        /// <param name="participantName">The participant name. (optional)</param>
        /// <param name="credit">Specifies whether to include credit operations in the report. (optional)</param>
        /// <param name="debit">Specifies whether to include debit operations in the report. (optional)</param>
        /// <param name="type">The operation type to filter by. (optional)</param>
        /// <param name="status">The operation status to filter by. (optional)</param>
        /// <param name="orderBy">The field to order by. (optional)</param>
        /// <param name="orderType">Order direction: Ascending or Descending. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-operations/">REST API Reference for GetCustomerOperations Operation</seealso>
        /// <returns>ReportWrapper</returns>
        ReportWrapper GetCustomerOperations(int? offset = default, int? limit = default, List<string>? serviceName = default, DateTime? startDate = default, DateTime? endDate = default, string? participantName = default, bool? credit = default, bool? debit = default, OperationType? type = default, OperationStatus? status = default, string? orderBy = default, OperationOrderType? orderType = default);

        /// <summary>
        /// Get the customer operations
        /// </summary>
        /// <remarks>
        /// Returns the report of customer operations from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">The number of items to skip for pagination. The default value is 0. (optional)</param>
        /// <param name="limit">The maximum number of items to return for pagination. The default value is 25. (optional)</param>
        /// <param name="serviceName">The service name list. A single string is also accepted for backward compatibility. (optional)</param>
        /// <param name="startDate">The report start date. (optional)</param>
        /// <param name="endDate">The report end date. (optional)</param>
        /// <param name="participantName">The participant name. (optional)</param>
        /// <param name="credit">Specifies whether to include credit operations in the report. (optional)</param>
        /// <param name="debit">Specifies whether to include debit operations in the report. (optional)</param>
        /// <param name="type">The operation type to filter by. (optional)</param>
        /// <param name="status">The operation status to filter by. (optional)</param>
        /// <param name="orderBy">The field to order by. (optional)</param>
        /// <param name="orderType">Order direction: Ascending or Descending. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-operations/">REST API Reference for GetCustomerOperations Operation</seealso>
        /// <returns>ApiResponse of ReportWrapper</returns>
        ApiResponse<ReportWrapper> GetCustomerOperationsWithHttpInfo(int? offset = default, int? limit = default, List<string>? serviceName = default, DateTime? startDate = default, DateTime? endDate = default, string? participantName = default, bool? credit = default, bool? debit = default, OperationType? type = default, OperationStatus? status = default, string? orderBy = default, OperationOrderType? orderType = default);
        /// <summary>
        /// Get the status of the customer operations report generation
        /// </summary>
        /// <remarks>
        /// Returns the status of generating a customer operations report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-operations-report/">REST API Reference for GetCustomerOperationsReport Operation</seealso>
        /// <returns>DocumentBuilderTaskWrapper</returns>
        DocumentBuilderTaskWrapper GetCustomerOperationsReport();

        /// <summary>
        /// Get the status of the customer operations report generation
        /// </summary>
        /// <remarks>
        /// Returns the status of generating a customer operations report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-operations-report/">REST API Reference for GetCustomerOperationsReport Operation</seealso>
        /// <returns>ApiResponse of DocumentBuilderTaskWrapper</returns>
        ApiResponse<DocumentBuilderTaskWrapper> GetCustomerOperationsReportWithHttpInfo();
        /// <summary>
        /// Get the customer service usage
        /// </summary>
        /// <remarks>
        /// Returns the customer usage statistics aggregated per service from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName">The service name list. (optional)</param>
        /// <param name="participantName">The participant name. (optional)</param>
        /// <param name="status">The operation status to filter by. (optional)</param>
        /// <param name="startDate">Start of the period (inclusive). (optional)</param>
        /// <param name="endDate">End of the period (inclusive). (optional)</param>
        /// <param name="metadata">Metadata key-value pairs to filter by. (optional)</param>
        /// <param name="offset">The number of items to skip for pagination. The default value is 0. (optional)</param>
        /// <param name="limit">The maximum number of items to return for pagination. The default value is 25. (optional)</param>
        /// <param name="orderBy">The field to order by. (optional)</param>
        /// <param name="orderType">Order direction: Ascending or Descending. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-service-usage/">REST API Reference for GetCustomerServiceUsage Operation</seealso>
        /// <returns>CustomerServiceUsageReportWrapper</returns>
        CustomerServiceUsageReportWrapper GetCustomerServiceUsage(List<string>? serviceName = default, string? participantName = default, OperationStatus? status = default, DateTime? startDate = default, DateTime? endDate = default, Dictionary<string, string>? metadata = default, int? offset = default, int? limit = default, string? orderBy = default, OperationOrderType? orderType = default);

        /// <summary>
        /// Get the customer service usage
        /// </summary>
        /// <remarks>
        /// Returns the customer usage statistics aggregated per service from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName">The service name list. (optional)</param>
        /// <param name="participantName">The participant name. (optional)</param>
        /// <param name="status">The operation status to filter by. (optional)</param>
        /// <param name="startDate">Start of the period (inclusive). (optional)</param>
        /// <param name="endDate">End of the period (inclusive). (optional)</param>
        /// <param name="metadata">Metadata key-value pairs to filter by. (optional)</param>
        /// <param name="offset">The number of items to skip for pagination. The default value is 0. (optional)</param>
        /// <param name="limit">The maximum number of items to return for pagination. The default value is 25. (optional)</param>
        /// <param name="orderBy">The field to order by. (optional)</param>
        /// <param name="orderType">Order direction: Ascending or Descending. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-service-usage/">REST API Reference for GetCustomerServiceUsage Operation</seealso>
        /// <returns>ApiResponse of CustomerServiceUsageReportWrapper</returns>
        ApiResponse<CustomerServiceUsageReportWrapper> GetCustomerServiceUsageWithHttpInfo(List<string>? serviceName = default, string? participantName = default, OperationStatus? status = default, DateTime? startDate = default, DateTime? endDate = default, Dictionary<string, string>? metadata = default, int? offset = default, int? limit = default, string? orderBy = default, OperationOrderType? orderType = default);
        /// <summary>
        /// Get the status of the customer service usage report generation
        /// </summary>
        /// <remarks>
        /// Returns the status of generating a customer service usage report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-service-usage-report/">REST API Reference for GetCustomerServiceUsageReport Operation</seealso>
        /// <returns>DocumentBuilderTaskWrapper</returns>
        DocumentBuilderTaskWrapper GetCustomerServiceUsageReport();

        /// <summary>
        /// Get the status of the customer service usage report generation
        /// </summary>
        /// <remarks>
        /// Returns the status of generating a customer service usage report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-service-usage-report/">REST API Reference for GetCustomerServiceUsageReport Operation</seealso>
        /// <returns>ApiResponse of DocumentBuilderTaskWrapper</returns>
        ApiResponse<DocumentBuilderTaskWrapper> GetCustomerServiceUsageReportWithHttpInfo();
        /// <summary>
        /// Get the payment account
        /// </summary>
        /// <remarks>
        /// Returns the URL to the payment account.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">The URL where the user will be redirected after payment processing. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-account/">REST API Reference for GetPaymentAccount Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper GetPaymentAccount(string? backUrl = default);

        /// <summary>
        /// Get the payment account
        /// </summary>
        /// <remarks>
        /// Returns the URL to the payment account.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">The URL where the user will be redirected after payment processing. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-account/">REST API Reference for GetPaymentAccount Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> GetPaymentAccountWithHttpInfo(string? backUrl = default);
        /// <summary>
        /// Get currencies
        /// </summary>
        /// <remarks>
        /// Returns the available portal currencies.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-currencies/">REST API Reference for GetPaymentCurrencies Operation</seealso>
        /// <returns>CurrenciesArrayWrapper</returns>
        CurrenciesArrayWrapper GetPaymentCurrencies();

        /// <summary>
        /// Get currencies
        /// </summary>
        /// <remarks>
        /// Returns the available portal currencies.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-currencies/">REST API Reference for GetPaymentCurrencies Operation</seealso>
        /// <returns>ApiResponse of CurrenciesArrayWrapper</returns>
        ApiResponse<CurrenciesArrayWrapper> GetPaymentCurrenciesWithHttpInfo();
        /// <summary>
        /// Get quotas
        /// </summary>
        /// <remarks>
        /// Returns the available portal quotas.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wallet">Specifies whether to return the wallet quotas only. (optional)</param>
        /// <param name="additional">Specifies whether to return additional quotas only. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-quotas/">REST API Reference for GetPaymentQuotas Operation</seealso>
        /// <returns>QuotaArrayWrapper</returns>
        QuotaArrayWrapper GetPaymentQuotas(bool? wallet = default, bool? additional = default);

        /// <summary>
        /// Get quotas
        /// </summary>
        /// <remarks>
        /// Returns the available portal quotas.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wallet">Specifies whether to return the wallet quotas only. (optional)</param>
        /// <param name="additional">Specifies whether to return additional quotas only. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-quotas/">REST API Reference for GetPaymentQuotas Operation</seealso>
        /// <returns>ApiResponse of QuotaArrayWrapper</returns>
        ApiResponse<QuotaArrayWrapper> GetPaymentQuotasWithHttpInfo(bool? wallet = default, bool? additional = default);
        /// <summary>
        /// Get the payment page URL
        /// </summary>
        /// <remarks>
        /// Returns the URL to the payment page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentUrlRequestDto">The request parameters for the payment URL configuration with quantity information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-url/">REST API Reference for GetPaymentUrl Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper GetPaymentUrl(PaymentUrlRequestDto? paymentUrlRequestDto = default);

        /// <summary>
        /// Get the payment page URL
        /// </summary>
        /// <remarks>
        /// Returns the URL to the payment page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentUrlRequestDto">The request parameters for the payment URL configuration with quantity information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-url/">REST API Reference for GetPaymentUrl Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> GetPaymentUrlWithHttpInfo(PaymentUrlRequestDto? paymentUrlRequestDto = default);
        /// <summary>
        /// Get prices
        /// </summary>
        /// <remarks>
        /// Returns the available portal prices.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-prices/">REST API Reference for GetPortalPrices Operation</seealso>
        /// <returns>GetPortalPrices200Response</returns>
        GetPortalPrices200Response GetPortalPrices();

        /// <summary>
        /// Get prices
        /// </summary>
        /// <remarks>
        /// Returns the available portal prices.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-prices/">REST API Reference for GetPortalPrices Operation</seealso>
        /// <returns>ApiResponse of GetPortalPrices200Response</returns>
        ApiResponse<GetPortalPrices200Response> GetPortalPricesWithHttpInfo();
        /// <summary>
        /// Get quota payment information
        /// </summary>
        /// <remarks>
        /// Returns the payment information about the current portal quota.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-quota-payment-information/">REST API Reference for GetQuotaPaymentInformation Operation</seealso>
        /// <returns>QuotaWrapper</returns>
        QuotaWrapper GetQuotaPaymentInformation(bool? refresh = default);

        /// <summary>
        /// Get quota payment information
        /// </summary>
        /// <remarks>
        /// Returns the payment information about the current portal quota.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-quota-payment-information/">REST API Reference for GetQuotaPaymentInformation Operation</seealso>
        /// <returns>ApiResponse of QuotaWrapper</returns>
        ApiResponse<QuotaWrapper> GetQuotaPaymentInformationWithHttpInfo(bool? refresh = default);
        /// <summary>
        /// Get restricted AI models
        /// </summary>
        /// <remarks>
        /// Returns the list of AI chat model IDs that are restricted (disabled) for the current tenant.  Restricted models cannot be used for AI chat conversations by any user within the portal.  Only DocSpace administrators can access this endpoint.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-restricted-ai-models/">REST API Reference for GetRestrictedAiModels Operation</seealso>
        /// <returns>RestrictedModelsResponseWrapper</returns>
        RestrictedModelsResponseWrapper GetRestrictedAiModels();

        /// <summary>
        /// Get restricted AI models
        /// </summary>
        /// <remarks>
        /// Returns the list of AI chat model IDs that are restricted (disabled) for the current tenant.  Restricted models cannot be used for AI chat conversations by any user within the portal.  Only DocSpace administrators can access this endpoint.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-restricted-ai-models/">REST API Reference for GetRestrictedAiModels Operation</seealso>
        /// <returns>ApiResponse of RestrictedModelsResponseWrapper</returns>
        ApiResponse<RestrictedModelsResponseWrapper> GetRestrictedAiModelsWithHttpInfo();
        /// <summary>
        /// Get the subscription balance information
        /// </summary>
        /// <remarks>
        /// Returns the information about the current subscription and its unused (prorated) balance.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-subscription-balance-info/">REST API Reference for GetSubscriptionBalanceInfo Operation</seealso>
        /// <returns>SubscriptionBalanceInfoWrapper</returns>
        SubscriptionBalanceInfoWrapper GetSubscriptionBalanceInfo();

        /// <summary>
        /// Get the subscription balance information
        /// </summary>
        /// <remarks>
        /// Returns the information about the current subscription and its unused (prorated) balance.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-subscription-balance-info/">REST API Reference for GetSubscriptionBalanceInfo Operation</seealso>
        /// <returns>ApiResponse of SubscriptionBalanceInfoWrapper</returns>
        ApiResponse<SubscriptionBalanceInfoWrapper> GetSubscriptionBalanceInfoWithHttpInfo();
        /// <summary>
        /// Gets the wallet service settings for the tenant.
        /// </summary>
        /// <remarks>
        /// Retrieves configuration settings related to the wallet service associated with the current tenant.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-wallet-service-settings/">REST API Reference for GetTenantWalletServiceSettings Operation</seealso>
        /// <returns>TenantWalletServiceSettingsWrapper</returns>
        TenantWalletServiceSettingsWrapper GetTenantWalletServiceSettings();

        /// <summary>
        /// Gets the wallet service settings for the tenant.
        /// </summary>
        /// <remarks>
        /// Retrieves configuration settings related to the wallet service associated with the current tenant.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-wallet-service-settings/">REST API Reference for GetTenantWalletServiceSettings Operation</seealso>
        /// <returns>ApiResponse of TenantWalletServiceSettingsWrapper</returns>
        ApiResponse<TenantWalletServiceSettingsWrapper> GetTenantWalletServiceSettingsWithHttpInfo();
        /// <summary>
        /// Gets the tenant wallet auto top up settings
        /// </summary>
        /// <remarks>
        /// Returns the wallet auto top up settings for the current tenant.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-wallet-settings/">REST API Reference for GetTenantWalletSettings Operation</seealso>
        /// <returns>TenantWalletSettingsWrapper</returns>
        TenantWalletSettingsWrapper GetTenantWalletSettings();

        /// <summary>
        /// Gets the tenant wallet auto top up settings
        /// </summary>
        /// <remarks>
        /// Returns the wallet auto top up settings for the current tenant.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-wallet-settings/">REST API Reference for GetTenantWalletSettings Operation</seealso>
        /// <returns>ApiResponse of TenantWalletSettingsWrapper</returns>
        ApiResponse<TenantWalletSettingsWrapper> GetTenantWalletSettingsWithHttpInfo();
        /// <summary>
        /// Get wallet service
        /// </summary>
        /// <remarks>
        /// Returns the specified wallet service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="service">The wallet service type.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-wallet-service/">REST API Reference for GetWalletService Operation</seealso>
        /// <returns>WalletServiceWrapper</returns>
        WalletServiceWrapper GetWalletService(TenantWalletService service);

        /// <summary>
        /// Get wallet service
        /// </summary>
        /// <remarks>
        /// Returns the specified wallet service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="service">The wallet service type.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-wallet-service/">REST API Reference for GetWalletService Operation</seealso>
        /// <returns>ApiResponse of WalletServiceWrapper</returns>
        ApiResponse<WalletServiceWrapper> GetWalletServiceWithHttpInfo(TenantWalletService service);
        /// <summary>
        /// Get wallet services
        /// </summary>
        /// <remarks>
        /// Returns the available wallet services.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-wallet-services/">REST API Reference for GetWalletServices Operation</seealso>
        /// <returns>WalletServiceArrayWrapper</returns>
        WalletServiceArrayWrapper GetWalletServices();

        /// <summary>
        /// Get wallet services
        /// </summary>
        /// <remarks>
        /// Returns the available wallet services.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-wallet-services/">REST API Reference for GetWalletServices Operation</seealso>
        /// <returns>ApiResponse of WalletServiceArrayWrapper</returns>
        ApiResponse<WalletServiceArrayWrapper> GetWalletServicesWithHttpInfo();
        /// <summary>
        /// Move the subscription balance to the wallet and purchase admins
        /// </summary>
        /// <remarks>
        /// Cancels the current subscription, moves its unused balance to the wallet, and purchases the requested number of  admins from the wallet. If the wallet balance is not enough, it is topped up for the missing amount first  (with several attempts, as the balance may be consumed concurrently).
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quantityRequestDto">The request parameters for specifying payment quantity. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-subscription-to-wallet/">REST API Reference for MoveSubscriptionToWallet Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper MoveSubscriptionToWallet(QuantityRequestDto? quantityRequestDto = default);

        /// <summary>
        /// Move the subscription balance to the wallet and purchase admins
        /// </summary>
        /// <remarks>
        /// Cancels the current subscription, moves its unused balance to the wallet, and purchases the requested number of  admins from the wallet. If the wallet balance is not enough, it is topped up for the missing amount first  (with several attempts, as the balance may be consumed concurrently).
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quantityRequestDto">The request parameters for specifying payment quantity. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-subscription-to-wallet/">REST API Reference for MoveSubscriptionToWallet Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> MoveSubscriptionToWalletWithHttpInfo(QuantityRequestDto? quantityRequestDto = default);
        /// <summary>
        /// Send a payment request
        /// </summary>
        /// <remarks>
        /// Sends a request for the portal payment.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesRequestsDto">The request parameters for handling sales and payment inquiries in the portal. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-payment-request/">REST API Reference for SendPaymentRequest Operation</seealso>
        /// <returns></returns>
        void SendPaymentRequest(SalesRequestsDto? salesRequestsDto = default);

        /// <summary>
        /// Send a payment request
        /// </summary>
        /// <remarks>
        /// Sends a request for the portal payment.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesRequestsDto">The request parameters for handling sales and payment inquiries in the portal. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-payment-request/">REST API Reference for SendPaymentRequest Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> SendPaymentRequestWithHttpInfo(SalesRequestsDto? salesRequestsDto = default);
        /// <summary>
        /// Set restricted AI models
        /// </summary>
        /// <remarks>
        /// Overwrites the entire set of restricted AI model IDs for the current tenant.  The request body must contain the complete desired set — to add a restriction, include the new model alongside existing ones;  to remove one, omit it. An empty set lifts all restrictions. Only the portal payer can perform this action.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setRestrictedAiModelsRequestDto">The request parameters for setting restricted AI models. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-restricted-ai-models/">REST API Reference for SetRestrictedAiModels Operation</seealso>
        /// <returns>RestrictedModelsResponseWrapper</returns>
        RestrictedModelsResponseWrapper SetRestrictedAiModels(SetRestrictedAiModelsRequestDto? setRestrictedAiModelsRequestDto = default);

        /// <summary>
        /// Set restricted AI models
        /// </summary>
        /// <remarks>
        /// Overwrites the entire set of restricted AI model IDs for the current tenant.  The request body must contain the complete desired set — to add a restriction, include the new model alongside existing ones;  to remove one, omit it. An empty set lifts all restrictions. Only the portal payer can perform this action.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setRestrictedAiModelsRequestDto">The request parameters for setting restricted AI models. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-restricted-ai-models/">REST API Reference for SetRestrictedAiModels Operation</seealso>
        /// <returns>ApiResponse of RestrictedModelsResponseWrapper</returns>
        ApiResponse<RestrictedModelsResponseWrapper> SetRestrictedAiModelsWithHttpInfo(SetRestrictedAiModelsRequestDto? setRestrictedAiModelsRequestDto = default);
        /// <summary>
        /// Set the wallet auto top up settings
        /// </summary>
        /// <remarks>
        /// Updates the wallet auto top up settings for the current tenant.  Requires the tariff service to be configured and the user to be authorized as a payer.  Returns null if the tariff service is not configured or customer information/balance cannot be retrieved.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantWalletSettingsWrapper">The wrapper for the tenant wallet settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tenant-wallet-settings/">REST API Reference for SetTenantWalletSettings Operation</seealso>
        /// <returns>TenantWalletSettingsWrapper</returns>
        TenantWalletSettingsWrapper SetTenantWalletSettings(TenantWalletSettingsWrapper? tenantWalletSettingsWrapper = default);

        /// <summary>
        /// Set the wallet auto top up settings
        /// </summary>
        /// <remarks>
        /// Updates the wallet auto top up settings for the current tenant.  Requires the tariff service to be configured and the user to be authorized as a payer.  Returns null if the tariff service is not configured or customer information/balance cannot be retrieved.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantWalletSettingsWrapper">The wrapper for the tenant wallet settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tenant-wallet-settings/">REST API Reference for SetTenantWalletSettings Operation</seealso>
        /// <returns>ApiResponse of TenantWalletSettingsWrapper</returns>
        ApiResponse<TenantWalletSettingsWrapper> SetTenantWalletSettingsWithHttpInfo(TenantWalletSettingsWrapper? tenantWalletSettingsWrapper = default);
        /// <summary>
        /// Terminate the customer monthly usage report generation
        /// </summary>
        /// <remarks>
        /// Terminates generating a customer monthly usage report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-monthly-usage-report/">REST API Reference for TerminateCustomerMonthlyUsageReport Operation</seealso>
        /// <returns></returns>
        void TerminateCustomerMonthlyUsageReport();

        /// <summary>
        /// Terminate the customer monthly usage report generation
        /// </summary>
        /// <remarks>
        /// Terminates generating a customer monthly usage report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-monthly-usage-report/">REST API Reference for TerminateCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TerminateCustomerMonthlyUsageReportWithHttpInfo();
        /// <summary>
        /// Terminate the customer operations report generation
        /// </summary>
        /// <remarks>
        /// Terminates generating a customer operations report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-operations-report/">REST API Reference for TerminateCustomerOperationsReport Operation</seealso>
        /// <returns></returns>
        void TerminateCustomerOperationsReport();

        /// <summary>
        /// Terminate the customer operations report generation
        /// </summary>
        /// <remarks>
        /// Terminates generating a customer operations report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-operations-report/">REST API Reference for TerminateCustomerOperationsReport Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TerminateCustomerOperationsReportWithHttpInfo();
        /// <summary>
        /// Terminate the customer service usage report generation
        /// </summary>
        /// <remarks>
        /// Terminates generating a customer service usage report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-service-usage-report/">REST API Reference for TerminateCustomerServiceUsageReport Operation</seealso>
        /// <returns></returns>
        void TerminateCustomerServiceUsageReport();

        /// <summary>
        /// Terminate the customer service usage report generation
        /// </summary>
        /// <remarks>
        /// Terminates generating a customer service usage report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-service-usage-report/">REST API Reference for TerminateCustomerServiceUsageReport Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TerminateCustomerServiceUsageReportWithHttpInfo();
        /// <summary>
        /// Put money on deposit
        /// </summary>
        /// <remarks>
        /// Returns the result of putting money on deposit.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topUpDepositRequestDto">The request parameters for putting money on deposit. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/top-up-deposit/">REST API Reference for TopUpDeposit Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper TopUpDeposit(TopUpDepositRequestDto? topUpDepositRequestDto = default);

        /// <summary>
        /// Put money on deposit
        /// </summary>
        /// <remarks>
        /// Returns the result of putting money on deposit.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topUpDepositRequestDto">The request parameters for putting money on deposit. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/top-up-deposit/">REST API Reference for TopUpDeposit Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> TopUpDepositWithHttpInfo(TopUpDepositRequestDto? topUpDepositRequestDto = default);
        /// <summary>
        /// Update the payment quantity
        /// </summary>
        /// <remarks>
        /// Updates the payment quantity with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quantityRequestDto">The request parameters for specifying payment quantity. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-payment/">REST API Reference for UpdatePayment Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper UpdatePayment(QuantityRequestDto? quantityRequestDto = default);

        /// <summary>
        /// Update the payment quantity
        /// </summary>
        /// <remarks>
        /// Updates the payment quantity with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quantityRequestDto">The request parameters for specifying payment quantity. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-payment/">REST API Reference for UpdatePayment Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> UpdatePaymentWithHttpInfo(QuantityRequestDto? quantityRequestDto = default);
        /// <summary>
        /// Update the wallet payment quantity
        /// </summary>
        /// <remarks>
        /// Updates the wallet payment quantity with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The request parameters for specifying wallet payment quantity. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-wallet-payment/">REST API Reference for UpdateWalletPayment Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper UpdateWalletPayment(WalletQuantityRequestDto? walletQuantityRequestDto = default);

        /// <summary>
        /// Update the wallet payment quantity
        /// </summary>
        /// <remarks>
        /// Updates the wallet payment quantity with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The request parameters for specifying wallet payment quantity. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-wallet-payment/">REST API Reference for UpdateWalletPayment Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> UpdateWalletPaymentWithHttpInfo(WalletQuantityRequestDto? walletQuantityRequestDto = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPaymentApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Calculate the wallet payment amount
        /// </summary>
        /// <remarks>
        /// Calculates an amount of the wallet payment with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The request parameters for specifying wallet payment quantity. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/calculate-wallet-payment/">REST API Reference for CalculateWalletPayment Operation</seealso>
        /// <returns>Task of PaymentCalculationWrapper</returns>
        Task<PaymentCalculationWrapper> CalculateWalletPaymentAsync(WalletQuantityRequestDto? walletQuantityRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Calculate the wallet payment amount
        /// </summary>
        /// <remarks>
        /// Calculates an amount of the wallet payment with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The request parameters for specifying wallet payment quantity. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/calculate-wallet-payment/">REST API Reference for CalculateWalletPayment Operation</seealso>
        /// <returns>Task of ApiResponse (PaymentCalculationWrapper)</returns>
        Task<ApiResponse<PaymentCalculationWrapper>> CalculateWalletPaymentWithHttpInfoAsync(WalletQuantityRequestDto? walletQuantityRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Change tenant wallet service state
        /// </summary>
        /// <remarks>
        /// Changes the state of a wallet service for the current tenant.  Requires permission to edit portal settings and a configured tariff service.  Adds or removes the specified service from the enabled services list based on the enabled flag.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="changeWalletServiceStateRequestDto">The request parameters for changing the tenant wallet service state. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-tenant-wallet-service-state/">REST API Reference for ChangeTenantWalletServiceState Operation</seealso>
        /// <returns>Task of TenantWalletServiceSettingsWrapper</returns>
        Task<TenantWalletServiceSettingsWrapper> ChangeTenantWalletServiceStateAsync(ChangeWalletServiceStateRequestDto? changeWalletServiceStateRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Change tenant wallet service state
        /// </summary>
        /// <remarks>
        /// Changes the state of a wallet service for the current tenant.  Requires permission to edit portal settings and a configured tariff service.  Adds or removes the specified service from the enabled services list based on the enabled flag.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="changeWalletServiceStateRequestDto">The request parameters for changing the tenant wallet service state. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-tenant-wallet-service-state/">REST API Reference for ChangeTenantWalletServiceState Operation</seealso>
        /// <returns>Task of ApiResponse (TenantWalletServiceSettingsWrapper)</returns>
        Task<ApiResponse<TenantWalletServiceSettingsWrapper>> ChangeTenantWalletServiceStateWithHttpInfoAsync(ChangeWalletServiceStateRequestDto? changeWalletServiceStateRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Start the customer monthly usage report generation
        /// </summary>
        /// <remarks>
        /// Starts generating a customer monthly usage report as an xlsx file and saves it in Documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerMonthlyUsageReportRequestDto">The request parameters for generating a customer monthly usage report. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-monthly-usage-report/">REST API Reference for CreateCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>Task of DocumentBuilderTaskWrapper</returns>
        Task<DocumentBuilderTaskWrapper> CreateCustomerMonthlyUsageReportAsync(CustomerMonthlyUsageReportRequestDto? customerMonthlyUsageReportRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Start the customer monthly usage report generation
        /// </summary>
        /// <remarks>
        /// Starts generating a customer monthly usage report as an xlsx file and saves it in Documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerMonthlyUsageReportRequestDto">The request parameters for generating a customer monthly usage report. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-monthly-usage-report/">REST API Reference for CreateCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>Task of ApiResponse (DocumentBuilderTaskWrapper)</returns>
        Task<ApiResponse<DocumentBuilderTaskWrapper>> CreateCustomerMonthlyUsageReportWithHttpInfoAsync(CustomerMonthlyUsageReportRequestDto? customerMonthlyUsageReportRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Start the customer operations report generation
        /// </summary>
        /// <remarks>
        /// Starts generating a customer operations report as an xlsx file and saves it in Documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerOperationsReportRequestDto">The request parameters for generating a report on client operations. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-operations-report/">REST API Reference for CreateCustomerOperationsReport Operation</seealso>
        /// <returns>Task of DocumentBuilderTaskWrapper</returns>
        Task<DocumentBuilderTaskWrapper> CreateCustomerOperationsReportAsync(CustomerOperationsReportRequestDto? customerOperationsReportRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Start the customer operations report generation
        /// </summary>
        /// <remarks>
        /// Starts generating a customer operations report as an xlsx file and saves it in Documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerOperationsReportRequestDto">The request parameters for generating a report on client operations. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-operations-report/">REST API Reference for CreateCustomerOperationsReport Operation</seealso>
        /// <returns>Task of ApiResponse (DocumentBuilderTaskWrapper)</returns>
        Task<ApiResponse<DocumentBuilderTaskWrapper>> CreateCustomerOperationsReportWithHttpInfoAsync(CustomerOperationsReportRequestDto? customerOperationsReportRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Start the customer service usage report generation
        /// </summary>
        /// <remarks>
        /// Starts generating a customer service usage report as an xlsx file and saves it in Documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerServiceUsageReportRequestDto">The request parameters for generating a customer service usage report. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-service-usage-report/">REST API Reference for CreateCustomerServiceUsageReport Operation</seealso>
        /// <returns>Task of DocumentBuilderTaskWrapper</returns>
        Task<DocumentBuilderTaskWrapper> CreateCustomerServiceUsageReportAsync(CustomerServiceUsageReportRequestDto? customerServiceUsageReportRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Start the customer service usage report generation
        /// </summary>
        /// <remarks>
        /// Starts generating a customer service usage report as an xlsx file and saves it in Documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerServiceUsageReportRequestDto">The request parameters for generating a customer service usage report. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-service-usage-report/">REST API Reference for CreateCustomerServiceUsageReport Operation</seealso>
        /// <returns>Task of ApiResponse (DocumentBuilderTaskWrapper)</returns>
        Task<ApiResponse<DocumentBuilderTaskWrapper>> CreateCustomerServiceUsageReportWithHttpInfoAsync(CustomerServiceUsageReportRequestDto? customerServiceUsageReportRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Credit AI balance
        /// </summary>
        /// <remarks>
        /// Credits AI quota to the customer AI sub-account from their main balance.  Requires the customer to have a configured payment method.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="creditAiBalanceRequestDto">The request parameters for crediting AI quota to the customer AI subaccount. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/credit-ai-balance/">REST API Reference for CreditAiBalance Operation</seealso>
        /// <returns>Task of ServicePaymentWrapper</returns>
        Task<ServicePaymentWrapper> CreditAiBalanceAsync(CreditAiBalanceRequestDto? creditAiBalanceRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Credit AI balance
        /// </summary>
        /// <remarks>
        /// Credits AI quota to the customer AI sub-account from their main balance.  Requires the customer to have a configured payment method.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="creditAiBalanceRequestDto">The request parameters for crediting AI quota to the customer AI subaccount. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/credit-ai-balance/">REST API Reference for CreditAiBalance Operation</seealso>
        /// <returns>Task of ApiResponse (ServicePaymentWrapper)</returns>
        Task<ApiResponse<ServicePaymentWrapper>> CreditAiBalanceWithHttpInfoAsync(CreditAiBalanceRequestDto? creditAiBalanceRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get AI model prices
        /// </summary>
        /// <remarks>
        /// Retrieves the pricing information for AI models including chat, embedding, and web search services.  The prices are returned in the configured currency and normalized per million tokens.  Requires administrator permissions to access.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-ai-prices/">REST API Reference for GetAiPrices Operation</seealso>
        /// <returns>Task of AiPricesResponseWrapper</returns>
        Task<AiPricesResponseWrapper> GetAiPricesAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get AI model prices
        /// </summary>
        /// <remarks>
        /// Retrieves the pricing information for AI models including chat, embedding, and web search services.  The prices are returned in the configured currency and normalized per million tokens.  Requires administrator permissions to access.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-ai-prices/">REST API Reference for GetAiPrices Operation</seealso>
        /// <returns>Task of ApiResponse (AiPricesResponseWrapper)</returns>
        Task<ApiResponse<AiPricesResponseWrapper>> GetAiPricesWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the checkout setup page URL
        /// </summary>
        /// <remarks>
        /// Returns the URL to the checkout setup page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">The URL where the user will be redirected after setup cancellation.</param>
        /// <param name="successUrl">The URL where the user will be redirected after successful payment.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-checkout-setup-url/">REST API Reference for GetCheckoutSetupUrl Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        Task<StringWrapper> GetCheckoutSetupUrlAsync(string backUrl, string successUrl, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the checkout setup page URL
        /// </summary>
        /// <remarks>
        /// Returns the URL to the checkout setup page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">The URL where the user will be redirected after setup cancellation.</param>
        /// <param name="successUrl">The URL where the user will be redirected after successful payment.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-checkout-setup-url/">REST API Reference for GetCheckoutSetupUrl Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        Task<ApiResponse<StringWrapper>> GetCheckoutSetupUrlWithHttpInfoAsync(string backUrl, string successUrl, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the customer AI balance
        /// </summary>
        /// <remarks>
        /// Returns the AI quota balance of a customer from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-ai-balance/">REST API Reference for GetCustomerAiBalance Operation</seealso>
        /// <returns>Task of BalanceWrapper</returns>
        Task<BalanceWrapper> GetCustomerAiBalanceAsync(bool? refresh = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the customer AI balance
        /// </summary>
        /// <remarks>
        /// Returns the AI quota balance of a customer from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-ai-balance/">REST API Reference for GetCustomerAiBalance Operation</seealso>
        /// <returns>Task of ApiResponse (BalanceWrapper)</returns>
        Task<ApiResponse<BalanceWrapper>> GetCustomerAiBalanceWithHttpInfoAsync(bool? refresh = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the customer balance
        /// </summary>
        /// <remarks>
        /// Returns the customer balance from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-balance/">REST API Reference for GetCustomerBalance Operation</seealso>
        /// <returns>Task of BalanceWrapper</returns>
        Task<BalanceWrapper> GetCustomerBalanceAsync(bool? refresh = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the customer balance
        /// </summary>
        /// <remarks>
        /// Returns the customer balance from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-balance/">REST API Reference for GetCustomerBalance Operation</seealso>
        /// <returns>Task of ApiResponse (BalanceWrapper)</returns>
        Task<ApiResponse<BalanceWrapper>> GetCustomerBalanceWithHttpInfoAsync(bool? refresh = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the customer information
        /// </summary>
        /// <remarks>
        /// Returns the customer information.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-info/">REST API Reference for GetCustomerInfo Operation</seealso>
        /// <returns>Task of CustomerInfoWrapper</returns>
        Task<CustomerInfoWrapper> GetCustomerInfoAsync(bool? refresh = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the customer information
        /// </summary>
        /// <remarks>
        /// Returns the customer information.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-info/">REST API Reference for GetCustomerInfo Operation</seealso>
        /// <returns>Task of ApiResponse (CustomerInfoWrapper)</returns>
        Task<ApiResponse<CustomerInfoWrapper>> GetCustomerInfoWithHttpInfoAsync(bool? refresh = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the customer monthly usage
        /// </summary>
        /// <remarks>
        /// Returns the customer spending aggregated per calendar month from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Start of the period (inclusive). (optional)</param>
        /// <param name="endDate">End of the period (inclusive). (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-monthly-usage/">REST API Reference for GetCustomerMonthlyUsage Operation</seealso>
        /// <returns>Task of CustomerMonthlyUsageArrayWrapper</returns>
        Task<CustomerMonthlyUsageArrayWrapper> GetCustomerMonthlyUsageAsync(DateTime? startDate = default, DateTime? endDate = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the customer monthly usage
        /// </summary>
        /// <remarks>
        /// Returns the customer spending aggregated per calendar month from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Start of the period (inclusive). (optional)</param>
        /// <param name="endDate">End of the period (inclusive). (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-monthly-usage/">REST API Reference for GetCustomerMonthlyUsage Operation</seealso>
        /// <returns>Task of ApiResponse (CustomerMonthlyUsageArrayWrapper)</returns>
        Task<ApiResponse<CustomerMonthlyUsageArrayWrapper>> GetCustomerMonthlyUsageWithHttpInfoAsync(DateTime? startDate = default, DateTime? endDate = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the status of the customer monthly usage report generation
        /// </summary>
        /// <remarks>
        /// Returns the status of generating a customer monthly usage report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-monthly-usage-report/">REST API Reference for GetCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>Task of DocumentBuilderTaskWrapper</returns>
        Task<DocumentBuilderTaskWrapper> GetCustomerMonthlyUsageReportAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the status of the customer monthly usage report generation
        /// </summary>
        /// <remarks>
        /// Returns the status of generating a customer monthly usage report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-monthly-usage-report/">REST API Reference for GetCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>Task of ApiResponse (DocumentBuilderTaskWrapper)</returns>
        Task<ApiResponse<DocumentBuilderTaskWrapper>> GetCustomerMonthlyUsageReportWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the customer operations
        /// </summary>
        /// <remarks>
        /// Returns the report of customer operations from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">The number of items to skip for pagination. The default value is 0. (optional)</param>
        /// <param name="limit">The maximum number of items to return for pagination. The default value is 25. (optional)</param>
        /// <param name="serviceName">The service name list. A single string is also accepted for backward compatibility. (optional)</param>
        /// <param name="startDate">The report start date. (optional)</param>
        /// <param name="endDate">The report end date. (optional)</param>
        /// <param name="participantName">The participant name. (optional)</param>
        /// <param name="credit">Specifies whether to include credit operations in the report. (optional)</param>
        /// <param name="debit">Specifies whether to include debit operations in the report. (optional)</param>
        /// <param name="type">The operation type to filter by. (optional)</param>
        /// <param name="status">The operation status to filter by. (optional)</param>
        /// <param name="orderBy">The field to order by. (optional)</param>
        /// <param name="orderType">Order direction: Ascending or Descending. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-operations/">REST API Reference for GetCustomerOperations Operation</seealso>
        /// <returns>Task of ReportWrapper</returns>
        Task<ReportWrapper> GetCustomerOperationsAsync(int? offset = default, int? limit = default, List<string>? serviceName = default, DateTime? startDate = default, DateTime? endDate = default, string? participantName = default, bool? credit = default, bool? debit = default, OperationType? type = default, OperationStatus? status = default, string? orderBy = default, OperationOrderType? orderType = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the customer operations
        /// </summary>
        /// <remarks>
        /// Returns the report of customer operations from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">The number of items to skip for pagination. The default value is 0. (optional)</param>
        /// <param name="limit">The maximum number of items to return for pagination. The default value is 25. (optional)</param>
        /// <param name="serviceName">The service name list. A single string is also accepted for backward compatibility. (optional)</param>
        /// <param name="startDate">The report start date. (optional)</param>
        /// <param name="endDate">The report end date. (optional)</param>
        /// <param name="participantName">The participant name. (optional)</param>
        /// <param name="credit">Specifies whether to include credit operations in the report. (optional)</param>
        /// <param name="debit">Specifies whether to include debit operations in the report. (optional)</param>
        /// <param name="type">The operation type to filter by. (optional)</param>
        /// <param name="status">The operation status to filter by. (optional)</param>
        /// <param name="orderBy">The field to order by. (optional)</param>
        /// <param name="orderType">Order direction: Ascending or Descending. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-operations/">REST API Reference for GetCustomerOperations Operation</seealso>
        /// <returns>Task of ApiResponse (ReportWrapper)</returns>
        Task<ApiResponse<ReportWrapper>> GetCustomerOperationsWithHttpInfoAsync(int? offset = default, int? limit = default, List<string>? serviceName = default, DateTime? startDate = default, DateTime? endDate = default, string? participantName = default, bool? credit = default, bool? debit = default, OperationType? type = default, OperationStatus? status = default, string? orderBy = default, OperationOrderType? orderType = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the status of the customer operations report generation
        /// </summary>
        /// <remarks>
        /// Returns the status of generating a customer operations report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-operations-report/">REST API Reference for GetCustomerOperationsReport Operation</seealso>
        /// <returns>Task of DocumentBuilderTaskWrapper</returns>
        Task<DocumentBuilderTaskWrapper> GetCustomerOperationsReportAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the status of the customer operations report generation
        /// </summary>
        /// <remarks>
        /// Returns the status of generating a customer operations report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-operations-report/">REST API Reference for GetCustomerOperationsReport Operation</seealso>
        /// <returns>Task of ApiResponse (DocumentBuilderTaskWrapper)</returns>
        Task<ApiResponse<DocumentBuilderTaskWrapper>> GetCustomerOperationsReportWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the customer service usage
        /// </summary>
        /// <remarks>
        /// Returns the customer usage statistics aggregated per service from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName">The service name list. (optional)</param>
        /// <param name="participantName">The participant name. (optional)</param>
        /// <param name="status">The operation status to filter by. (optional)</param>
        /// <param name="startDate">Start of the period (inclusive). (optional)</param>
        /// <param name="endDate">End of the period (inclusive). (optional)</param>
        /// <param name="metadata">Metadata key-value pairs to filter by. (optional)</param>
        /// <param name="offset">The number of items to skip for pagination. The default value is 0. (optional)</param>
        /// <param name="limit">The maximum number of items to return for pagination. The default value is 25. (optional)</param>
        /// <param name="orderBy">The field to order by. (optional)</param>
        /// <param name="orderType">Order direction: Ascending or Descending. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-service-usage/">REST API Reference for GetCustomerServiceUsage Operation</seealso>
        /// <returns>Task of CustomerServiceUsageReportWrapper</returns>
        Task<CustomerServiceUsageReportWrapper> GetCustomerServiceUsageAsync(List<string>? serviceName = default, string? participantName = default, OperationStatus? status = default, DateTime? startDate = default, DateTime? endDate = default, Dictionary<string, string>? metadata = default, int? offset = default, int? limit = default, string? orderBy = default, OperationOrderType? orderType = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the customer service usage
        /// </summary>
        /// <remarks>
        /// Returns the customer usage statistics aggregated per service from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName">The service name list. (optional)</param>
        /// <param name="participantName">The participant name. (optional)</param>
        /// <param name="status">The operation status to filter by. (optional)</param>
        /// <param name="startDate">Start of the period (inclusive). (optional)</param>
        /// <param name="endDate">End of the period (inclusive). (optional)</param>
        /// <param name="metadata">Metadata key-value pairs to filter by. (optional)</param>
        /// <param name="offset">The number of items to skip for pagination. The default value is 0. (optional)</param>
        /// <param name="limit">The maximum number of items to return for pagination. The default value is 25. (optional)</param>
        /// <param name="orderBy">The field to order by. (optional)</param>
        /// <param name="orderType">Order direction: Ascending or Descending. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-service-usage/">REST API Reference for GetCustomerServiceUsage Operation</seealso>
        /// <returns>Task of ApiResponse (CustomerServiceUsageReportWrapper)</returns>
        Task<ApiResponse<CustomerServiceUsageReportWrapper>> GetCustomerServiceUsageWithHttpInfoAsync(List<string>? serviceName = default, string? participantName = default, OperationStatus? status = default, DateTime? startDate = default, DateTime? endDate = default, Dictionary<string, string>? metadata = default, int? offset = default, int? limit = default, string? orderBy = default, OperationOrderType? orderType = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the status of the customer service usage report generation
        /// </summary>
        /// <remarks>
        /// Returns the status of generating a customer service usage report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-service-usage-report/">REST API Reference for GetCustomerServiceUsageReport Operation</seealso>
        /// <returns>Task of DocumentBuilderTaskWrapper</returns>
        Task<DocumentBuilderTaskWrapper> GetCustomerServiceUsageReportAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the status of the customer service usage report generation
        /// </summary>
        /// <remarks>
        /// Returns the status of generating a customer service usage report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-service-usage-report/">REST API Reference for GetCustomerServiceUsageReport Operation</seealso>
        /// <returns>Task of ApiResponse (DocumentBuilderTaskWrapper)</returns>
        Task<ApiResponse<DocumentBuilderTaskWrapper>> GetCustomerServiceUsageReportWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the payment account
        /// </summary>
        /// <remarks>
        /// Returns the URL to the payment account.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">The URL where the user will be redirected after payment processing. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-account/">REST API Reference for GetPaymentAccount Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        Task<StringWrapper> GetPaymentAccountAsync(string? backUrl = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the payment account
        /// </summary>
        /// <remarks>
        /// Returns the URL to the payment account.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">The URL where the user will be redirected after payment processing. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-account/">REST API Reference for GetPaymentAccount Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        Task<ApiResponse<StringWrapper>> GetPaymentAccountWithHttpInfoAsync(string? backUrl = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get currencies
        /// </summary>
        /// <remarks>
        /// Returns the available portal currencies.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-currencies/">REST API Reference for GetPaymentCurrencies Operation</seealso>
        /// <returns>Task of CurrenciesArrayWrapper</returns>
        Task<CurrenciesArrayWrapper> GetPaymentCurrenciesAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get currencies
        /// </summary>
        /// <remarks>
        /// Returns the available portal currencies.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-currencies/">REST API Reference for GetPaymentCurrencies Operation</seealso>
        /// <returns>Task of ApiResponse (CurrenciesArrayWrapper)</returns>
        Task<ApiResponse<CurrenciesArrayWrapper>> GetPaymentCurrenciesWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get quotas
        /// </summary>
        /// <remarks>
        /// Returns the available portal quotas.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wallet">Specifies whether to return the wallet quotas only. (optional)</param>
        /// <param name="additional">Specifies whether to return additional quotas only. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-quotas/">REST API Reference for GetPaymentQuotas Operation</seealso>
        /// <returns>Task of QuotaArrayWrapper</returns>
        Task<QuotaArrayWrapper> GetPaymentQuotasAsync(bool? wallet = default, bool? additional = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get quotas
        /// </summary>
        /// <remarks>
        /// Returns the available portal quotas.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wallet">Specifies whether to return the wallet quotas only. (optional)</param>
        /// <param name="additional">Specifies whether to return additional quotas only. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-quotas/">REST API Reference for GetPaymentQuotas Operation</seealso>
        /// <returns>Task of ApiResponse (QuotaArrayWrapper)</returns>
        Task<ApiResponse<QuotaArrayWrapper>> GetPaymentQuotasWithHttpInfoAsync(bool? wallet = default, bool? additional = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the payment page URL
        /// </summary>
        /// <remarks>
        /// Returns the URL to the payment page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentUrlRequestDto">The request parameters for the payment URL configuration with quantity information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-url/">REST API Reference for GetPaymentUrl Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        Task<StringWrapper> GetPaymentUrlAsync(PaymentUrlRequestDto? paymentUrlRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the payment page URL
        /// </summary>
        /// <remarks>
        /// Returns the URL to the payment page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentUrlRequestDto">The request parameters for the payment URL configuration with quantity information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-url/">REST API Reference for GetPaymentUrl Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        Task<ApiResponse<StringWrapper>> GetPaymentUrlWithHttpInfoAsync(PaymentUrlRequestDto? paymentUrlRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get prices
        /// </summary>
        /// <remarks>
        /// Returns the available portal prices.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-prices/">REST API Reference for GetPortalPrices Operation</seealso>
        /// <returns>Task of GetPortalPrices200Response</returns>
        Task<GetPortalPrices200Response> GetPortalPricesAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get prices
        /// </summary>
        /// <remarks>
        /// Returns the available portal prices.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-prices/">REST API Reference for GetPortalPrices Operation</seealso>
        /// <returns>Task of ApiResponse (GetPortalPrices200Response)</returns>
        Task<ApiResponse<GetPortalPrices200Response>> GetPortalPricesWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get quota payment information
        /// </summary>
        /// <remarks>
        /// Returns the payment information about the current portal quota.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-quota-payment-information/">REST API Reference for GetQuotaPaymentInformation Operation</seealso>
        /// <returns>Task of QuotaWrapper</returns>
        Task<QuotaWrapper> GetQuotaPaymentInformationAsync(bool? refresh = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get quota payment information
        /// </summary>
        /// <remarks>
        /// Returns the payment information about the current portal quota.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-quota-payment-information/">REST API Reference for GetQuotaPaymentInformation Operation</seealso>
        /// <returns>Task of ApiResponse (QuotaWrapper)</returns>
        Task<ApiResponse<QuotaWrapper>> GetQuotaPaymentInformationWithHttpInfoAsync(bool? refresh = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get restricted AI models
        /// </summary>
        /// <remarks>
        /// Returns the list of AI chat model IDs that are restricted (disabled) for the current tenant.  Restricted models cannot be used for AI chat conversations by any user within the portal.  Only DocSpace administrators can access this endpoint.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-restricted-ai-models/">REST API Reference for GetRestrictedAiModels Operation</seealso>
        /// <returns>Task of RestrictedModelsResponseWrapper</returns>
        Task<RestrictedModelsResponseWrapper> GetRestrictedAiModelsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get restricted AI models
        /// </summary>
        /// <remarks>
        /// Returns the list of AI chat model IDs that are restricted (disabled) for the current tenant.  Restricted models cannot be used for AI chat conversations by any user within the portal.  Only DocSpace administrators can access this endpoint.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-restricted-ai-models/">REST API Reference for GetRestrictedAiModels Operation</seealso>
        /// <returns>Task of ApiResponse (RestrictedModelsResponseWrapper)</returns>
        Task<ApiResponse<RestrictedModelsResponseWrapper>> GetRestrictedAiModelsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the subscription balance information
        /// </summary>
        /// <remarks>
        /// Returns the information about the current subscription and its unused (prorated) balance.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-subscription-balance-info/">REST API Reference for GetSubscriptionBalanceInfo Operation</seealso>
        /// <returns>Task of SubscriptionBalanceInfoWrapper</returns>
        Task<SubscriptionBalanceInfoWrapper> GetSubscriptionBalanceInfoAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the subscription balance information
        /// </summary>
        /// <remarks>
        /// Returns the information about the current subscription and its unused (prorated) balance.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-subscription-balance-info/">REST API Reference for GetSubscriptionBalanceInfo Operation</seealso>
        /// <returns>Task of ApiResponse (SubscriptionBalanceInfoWrapper)</returns>
        Task<ApiResponse<SubscriptionBalanceInfoWrapper>> GetSubscriptionBalanceInfoWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the wallet service settings for the tenant.
        /// </summary>
        /// <remarks>
        /// Retrieves configuration settings related to the wallet service associated with the current tenant.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-wallet-service-settings/">REST API Reference for GetTenantWalletServiceSettings Operation</seealso>
        /// <returns>Task of TenantWalletServiceSettingsWrapper</returns>
        Task<TenantWalletServiceSettingsWrapper> GetTenantWalletServiceSettingsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the wallet service settings for the tenant.
        /// </summary>
        /// <remarks>
        /// Retrieves configuration settings related to the wallet service associated with the current tenant.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-wallet-service-settings/">REST API Reference for GetTenantWalletServiceSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantWalletServiceSettingsWrapper)</returns>
        Task<ApiResponse<TenantWalletServiceSettingsWrapper>> GetTenantWalletServiceSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the tenant wallet auto top up settings
        /// </summary>
        /// <remarks>
        /// Returns the wallet auto top up settings for the current tenant.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-wallet-settings/">REST API Reference for GetTenantWalletSettings Operation</seealso>
        /// <returns>Task of TenantWalletSettingsWrapper</returns>
        Task<TenantWalletSettingsWrapper> GetTenantWalletSettingsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the tenant wallet auto top up settings
        /// </summary>
        /// <remarks>
        /// Returns the wallet auto top up settings for the current tenant.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-wallet-settings/">REST API Reference for GetTenantWalletSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantWalletSettingsWrapper)</returns>
        Task<ApiResponse<TenantWalletSettingsWrapper>> GetTenantWalletSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get wallet service
        /// </summary>
        /// <remarks>
        /// Returns the specified wallet service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="service">The wallet service type.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-wallet-service/">REST API Reference for GetWalletService Operation</seealso>
        /// <returns>Task of WalletServiceWrapper</returns>
        Task<WalletServiceWrapper> GetWalletServiceAsync(TenantWalletService service, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get wallet service
        /// </summary>
        /// <remarks>
        /// Returns the specified wallet service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="service">The wallet service type.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-wallet-service/">REST API Reference for GetWalletService Operation</seealso>
        /// <returns>Task of ApiResponse (WalletServiceWrapper)</returns>
        Task<ApiResponse<WalletServiceWrapper>> GetWalletServiceWithHttpInfoAsync(TenantWalletService service, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get wallet services
        /// </summary>
        /// <remarks>
        /// Returns the available wallet services.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-wallet-services/">REST API Reference for GetWalletServices Operation</seealso>
        /// <returns>Task of WalletServiceArrayWrapper</returns>
        Task<WalletServiceArrayWrapper> GetWalletServicesAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get wallet services
        /// </summary>
        /// <remarks>
        /// Returns the available wallet services.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-wallet-services/">REST API Reference for GetWalletServices Operation</seealso>
        /// <returns>Task of ApiResponse (WalletServiceArrayWrapper)</returns>
        Task<ApiResponse<WalletServiceArrayWrapper>> GetWalletServicesWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Move the subscription balance to the wallet and purchase admins
        /// </summary>
        /// <remarks>
        /// Cancels the current subscription, moves its unused balance to the wallet, and purchases the requested number of  admins from the wallet. If the wallet balance is not enough, it is topped up for the missing amount first  (with several attempts, as the balance may be consumed concurrently).
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quantityRequestDto">The request parameters for specifying payment quantity. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-subscription-to-wallet/">REST API Reference for MoveSubscriptionToWallet Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        Task<BooleanWrapper> MoveSubscriptionToWalletAsync(QuantityRequestDto? quantityRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Move the subscription balance to the wallet and purchase admins
        /// </summary>
        /// <remarks>
        /// Cancels the current subscription, moves its unused balance to the wallet, and purchases the requested number of  admins from the wallet. If the wallet balance is not enough, it is topped up for the missing amount first  (with several attempts, as the balance may be consumed concurrently).
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quantityRequestDto">The request parameters for specifying payment quantity. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-subscription-to-wallet/">REST API Reference for MoveSubscriptionToWallet Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        Task<ApiResponse<BooleanWrapper>> MoveSubscriptionToWalletWithHttpInfoAsync(QuantityRequestDto? quantityRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Send a payment request
        /// </summary>
        /// <remarks>
        /// Sends a request for the portal payment.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesRequestsDto">The request parameters for handling sales and payment inquiries in the portal. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-payment-request/">REST API Reference for SendPaymentRequest Operation</seealso>
        /// <returns>Task of void</returns>
        Task SendPaymentRequestAsync(SalesRequestsDto? salesRequestsDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Send a payment request
        /// </summary>
        /// <remarks>
        /// Sends a request for the portal payment.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesRequestsDto">The request parameters for handling sales and payment inquiries in the portal. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-payment-request/">REST API Reference for SendPaymentRequest Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> SendPaymentRequestWithHttpInfoAsync(SalesRequestsDto? salesRequestsDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Set restricted AI models
        /// </summary>
        /// <remarks>
        /// Overwrites the entire set of restricted AI model IDs for the current tenant.  The request body must contain the complete desired set — to add a restriction, include the new model alongside existing ones;  to remove one, omit it. An empty set lifts all restrictions. Only the portal payer can perform this action.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setRestrictedAiModelsRequestDto">The request parameters for setting restricted AI models. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-restricted-ai-models/">REST API Reference for SetRestrictedAiModels Operation</seealso>
        /// <returns>Task of RestrictedModelsResponseWrapper</returns>
        Task<RestrictedModelsResponseWrapper> SetRestrictedAiModelsAsync(SetRestrictedAiModelsRequestDto? setRestrictedAiModelsRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Set restricted AI models
        /// </summary>
        /// <remarks>
        /// Overwrites the entire set of restricted AI model IDs for the current tenant.  The request body must contain the complete desired set — to add a restriction, include the new model alongside existing ones;  to remove one, omit it. An empty set lifts all restrictions. Only the portal payer can perform this action.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setRestrictedAiModelsRequestDto">The request parameters for setting restricted AI models. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-restricted-ai-models/">REST API Reference for SetRestrictedAiModels Operation</seealso>
        /// <returns>Task of ApiResponse (RestrictedModelsResponseWrapper)</returns>
        Task<ApiResponse<RestrictedModelsResponseWrapper>> SetRestrictedAiModelsWithHttpInfoAsync(SetRestrictedAiModelsRequestDto? setRestrictedAiModelsRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Set the wallet auto top up settings
        /// </summary>
        /// <remarks>
        /// Updates the wallet auto top up settings for the current tenant.  Requires the tariff service to be configured and the user to be authorized as a payer.  Returns null if the tariff service is not configured or customer information/balance cannot be retrieved.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantWalletSettingsWrapper">The wrapper for the tenant wallet settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tenant-wallet-settings/">REST API Reference for SetTenantWalletSettings Operation</seealso>
        /// <returns>Task of TenantWalletSettingsWrapper</returns>
        Task<TenantWalletSettingsWrapper> SetTenantWalletSettingsAsync(TenantWalletSettingsWrapper? tenantWalletSettingsWrapper = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Set the wallet auto top up settings
        /// </summary>
        /// <remarks>
        /// Updates the wallet auto top up settings for the current tenant.  Requires the tariff service to be configured and the user to be authorized as a payer.  Returns null if the tariff service is not configured or customer information/balance cannot be retrieved.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantWalletSettingsWrapper">The wrapper for the tenant wallet settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tenant-wallet-settings/">REST API Reference for SetTenantWalletSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantWalletSettingsWrapper)</returns>
        Task<ApiResponse<TenantWalletSettingsWrapper>> SetTenantWalletSettingsWithHttpInfoAsync(TenantWalletSettingsWrapper? tenantWalletSettingsWrapper = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Terminate the customer monthly usage report generation
        /// </summary>
        /// <remarks>
        /// Terminates generating a customer monthly usage report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-monthly-usage-report/">REST API Reference for TerminateCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>Task of void</returns>
        Task TerminateCustomerMonthlyUsageReportAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Terminate the customer monthly usage report generation
        /// </summary>
        /// <remarks>
        /// Terminates generating a customer monthly usage report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-monthly-usage-report/">REST API Reference for TerminateCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> TerminateCustomerMonthlyUsageReportWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Terminate the customer operations report generation
        /// </summary>
        /// <remarks>
        /// Terminates generating a customer operations report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-operations-report/">REST API Reference for TerminateCustomerOperationsReport Operation</seealso>
        /// <returns>Task of void</returns>
        Task TerminateCustomerOperationsReportAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Terminate the customer operations report generation
        /// </summary>
        /// <remarks>
        /// Terminates generating a customer operations report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-operations-report/">REST API Reference for TerminateCustomerOperationsReport Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> TerminateCustomerOperationsReportWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Terminate the customer service usage report generation
        /// </summary>
        /// <remarks>
        /// Terminates generating a customer service usage report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-service-usage-report/">REST API Reference for TerminateCustomerServiceUsageReport Operation</seealso>
        /// <returns>Task of void</returns>
        Task TerminateCustomerServiceUsageReportAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Terminate the customer service usage report generation
        /// </summary>
        /// <remarks>
        /// Terminates generating a customer service usage report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-service-usage-report/">REST API Reference for TerminateCustomerServiceUsageReport Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> TerminateCustomerServiceUsageReportWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Put money on deposit
        /// </summary>
        /// <remarks>
        /// Returns the result of putting money on deposit.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topUpDepositRequestDto">The request parameters for putting money on deposit. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/top-up-deposit/">REST API Reference for TopUpDeposit Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        Task<BooleanWrapper> TopUpDepositAsync(TopUpDepositRequestDto? topUpDepositRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Put money on deposit
        /// </summary>
        /// <remarks>
        /// Returns the result of putting money on deposit.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topUpDepositRequestDto">The request parameters for putting money on deposit. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/top-up-deposit/">REST API Reference for TopUpDeposit Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        Task<ApiResponse<BooleanWrapper>> TopUpDepositWithHttpInfoAsync(TopUpDepositRequestDto? topUpDepositRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the payment quantity
        /// </summary>
        /// <remarks>
        /// Updates the payment quantity with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quantityRequestDto">The request parameters for specifying payment quantity. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-payment/">REST API Reference for UpdatePayment Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        Task<BooleanWrapper> UpdatePaymentAsync(QuantityRequestDto? quantityRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update the payment quantity
        /// </summary>
        /// <remarks>
        /// Updates the payment quantity with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quantityRequestDto">The request parameters for specifying payment quantity. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-payment/">REST API Reference for UpdatePayment Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        Task<ApiResponse<BooleanWrapper>> UpdatePaymentWithHttpInfoAsync(QuantityRequestDto? quantityRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the wallet payment quantity
        /// </summary>
        /// <remarks>
        /// Updates the wallet payment quantity with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The request parameters for specifying wallet payment quantity. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-wallet-payment/">REST API Reference for UpdateWalletPayment Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        Task<BooleanWrapper> UpdateWalletPaymentAsync(WalletQuantityRequestDto? walletQuantityRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update the wallet payment quantity
        /// </summary>
        /// <remarks>
        /// Updates the wallet payment quantity with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The request parameters for specifying wallet payment quantity. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-wallet-payment/">REST API Reference for UpdateWalletPayment Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        Task<ApiResponse<BooleanWrapper>> UpdateWalletPaymentWithHttpInfoAsync(WalletQuantityRequestDto? walletQuantityRequestDto = default, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPaymentApi : IPaymentApiSync, IPaymentApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PaymentApi : IDisposable, IPaymentApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public PaymentApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public PaymentApi(string basePath)
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
        /// Initializes a new instance of the <see cref="PaymentApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public PaymentApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="PaymentApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public PaymentApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentApi"/> class.
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
        public PaymentApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="PaymentApi"/> class using a Configuration object.
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
        public PaymentApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="PaymentApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public PaymentApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Calculate the wallet payment amount
        /// </summary>
        /// <remarks>
        /// Calculates an amount of the wallet payment with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The request parameters for specifying wallet payment quantity. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/calculate-wallet-payment/">REST API Reference for CalculateWalletPayment Operation</seealso>
        /// <returns>PaymentCalculationWrapper</returns>
        public PaymentCalculationWrapper CalculateWalletPayment(WalletQuantityRequestDto? walletQuantityRequestDto = default)
        {
            var localVarResponse = CalculateWalletPaymentWithHttpInfo(walletQuantityRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Calculate the wallet payment amount
        /// </summary>
        /// <remarks>
        /// Calculates an amount of the wallet payment with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The request parameters for specifying wallet payment quantity. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/calculate-wallet-payment/">REST API Reference for CalculateWalletPayment Operation</seealso>
        /// <returns>ApiResponse of PaymentCalculationWrapper</returns>
        public ApiResponse<PaymentCalculationWrapper> CalculateWalletPaymentWithHttpInfo(WalletQuantityRequestDto? walletQuantityRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (walletQuantityRequestDto != null) localVarRequestOptions.Data = walletQuantityRequestDto;

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
            var localVarResponse = Client.Put<PaymentCalculationWrapper>("/api/2.0/portal/payment/calculatewallet", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CalculateWalletPayment", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Calculate the wallet payment amount
        /// </summary>
        /// <remarks>
        /// Calculates an amount of the wallet payment with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The request parameters for specifying wallet payment quantity. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/calculate-wallet-payment/">REST API Reference for CalculateWalletPayment Operation</seealso>
        /// <returns>Task of PaymentCalculationWrapper</returns>
        public async Task<PaymentCalculationWrapper> CalculateWalletPaymentAsync(WalletQuantityRequestDto? walletQuantityRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CalculateWalletPaymentWithHttpInfoAsync(walletQuantityRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Calculate the wallet payment amount
        /// </summary>
        /// <remarks>
        /// Calculates an amount of the wallet payment with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The request parameters for specifying wallet payment quantity. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/calculate-wallet-payment/">REST API Reference for CalculateWalletPayment Operation</seealso>
        /// <returns>Task of ApiResponse (PaymentCalculationWrapper)</returns>
        public async Task<ApiResponse<PaymentCalculationWrapper>> CalculateWalletPaymentWithHttpInfoAsync(WalletQuantityRequestDto? walletQuantityRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (walletQuantityRequestDto != null) localVarRequestOptions.Data = walletQuantityRequestDto;

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

            var localVarResponse = await AsynchronousClient.PutAsync<PaymentCalculationWrapper>("/api/2.0/portal/payment/calculatewallet", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CalculateWalletPayment", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change tenant wallet service state
        /// </summary>
        /// <remarks>
        /// Changes the state of a wallet service for the current tenant.  Requires permission to edit portal settings and a configured tariff service.  Adds or removes the specified service from the enabled services list based on the enabled flag.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="changeWalletServiceStateRequestDto">The request parameters for changing the tenant wallet service state. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-tenant-wallet-service-state/">REST API Reference for ChangeTenantWalletServiceState Operation</seealso>
        /// <returns>TenantWalletServiceSettingsWrapper</returns>
        public TenantWalletServiceSettingsWrapper ChangeTenantWalletServiceState(ChangeWalletServiceStateRequestDto? changeWalletServiceStateRequestDto = default)
        {
            var localVarResponse = ChangeTenantWalletServiceStateWithHttpInfo(changeWalletServiceStateRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change tenant wallet service state
        /// </summary>
        /// <remarks>
        /// Changes the state of a wallet service for the current tenant.  Requires permission to edit portal settings and a configured tariff service.  Adds or removes the specified service from the enabled services list based on the enabled flag.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="changeWalletServiceStateRequestDto">The request parameters for changing the tenant wallet service state. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-tenant-wallet-service-state/">REST API Reference for ChangeTenantWalletServiceState Operation</seealso>
        /// <returns>ApiResponse of TenantWalletServiceSettingsWrapper</returns>
        public ApiResponse<TenantWalletServiceSettingsWrapper> ChangeTenantWalletServiceStateWithHttpInfo(ChangeWalletServiceStateRequestDto? changeWalletServiceStateRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (changeWalletServiceStateRequestDto != null) localVarRequestOptions.Data = changeWalletServiceStateRequestDto;

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
            var localVarResponse = Client.Post<TenantWalletServiceSettingsWrapper>("/api/2.0/portal/payment/servicestate", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ChangeTenantWalletServiceState", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change tenant wallet service state
        /// </summary>
        /// <remarks>
        /// Changes the state of a wallet service for the current tenant.  Requires permission to edit portal settings and a configured tariff service.  Adds or removes the specified service from the enabled services list based on the enabled flag.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="changeWalletServiceStateRequestDto">The request parameters for changing the tenant wallet service state. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-tenant-wallet-service-state/">REST API Reference for ChangeTenantWalletServiceState Operation</seealso>
        /// <returns>Task of TenantWalletServiceSettingsWrapper</returns>
        public async Task<TenantWalletServiceSettingsWrapper> ChangeTenantWalletServiceStateAsync(ChangeWalletServiceStateRequestDto? changeWalletServiceStateRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await ChangeTenantWalletServiceStateWithHttpInfoAsync(changeWalletServiceStateRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change tenant wallet service state
        /// </summary>
        /// <remarks>
        /// Changes the state of a wallet service for the current tenant.  Requires permission to edit portal settings and a configured tariff service.  Adds or removes the specified service from the enabled services list based on the enabled flag.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="changeWalletServiceStateRequestDto">The request parameters for changing the tenant wallet service state. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-tenant-wallet-service-state/">REST API Reference for ChangeTenantWalletServiceState Operation</seealso>
        /// <returns>Task of ApiResponse (TenantWalletServiceSettingsWrapper)</returns>
        public async Task<ApiResponse<TenantWalletServiceSettingsWrapper>> ChangeTenantWalletServiceStateWithHttpInfoAsync(ChangeWalletServiceStateRequestDto? changeWalletServiceStateRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (changeWalletServiceStateRequestDto != null) localVarRequestOptions.Data = changeWalletServiceStateRequestDto;

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

            var localVarResponse = await AsynchronousClient.PostAsync<TenantWalletServiceSettingsWrapper>("/api/2.0/portal/payment/servicestate", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ChangeTenantWalletServiceState", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Start the customer monthly usage report generation
        /// </summary>
        /// <remarks>
        /// Starts generating a customer monthly usage report as an xlsx file and saves it in Documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerMonthlyUsageReportRequestDto">The request parameters for generating a customer monthly usage report. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-monthly-usage-report/">REST API Reference for CreateCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>DocumentBuilderTaskWrapper</returns>
        public DocumentBuilderTaskWrapper CreateCustomerMonthlyUsageReport(CustomerMonthlyUsageReportRequestDto? customerMonthlyUsageReportRequestDto = default)
        {
            var localVarResponse = CreateCustomerMonthlyUsageReportWithHttpInfo(customerMonthlyUsageReportRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Start the customer monthly usage report generation
        /// </summary>
        /// <remarks>
        /// Starts generating a customer monthly usage report as an xlsx file and saves it in Documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerMonthlyUsageReportRequestDto">The request parameters for generating a customer monthly usage report. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-monthly-usage-report/">REST API Reference for CreateCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>ApiResponse of DocumentBuilderTaskWrapper</returns>
        public ApiResponse<DocumentBuilderTaskWrapper> CreateCustomerMonthlyUsageReportWithHttpInfo(CustomerMonthlyUsageReportRequestDto? customerMonthlyUsageReportRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (customerMonthlyUsageReportRequestDto != null) localVarRequestOptions.Data = customerMonthlyUsageReportRequestDto;

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
            var localVarResponse = Client.Post<DocumentBuilderTaskWrapper>("/api/2.0/portal/payment/customer/usage/monthly/report", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateCustomerMonthlyUsageReport", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Start the customer monthly usage report generation
        /// </summary>
        /// <remarks>
        /// Starts generating a customer monthly usage report as an xlsx file and saves it in Documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerMonthlyUsageReportRequestDto">The request parameters for generating a customer monthly usage report. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-monthly-usage-report/">REST API Reference for CreateCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>Task of DocumentBuilderTaskWrapper</returns>
        public async Task<DocumentBuilderTaskWrapper> CreateCustomerMonthlyUsageReportAsync(CustomerMonthlyUsageReportRequestDto? customerMonthlyUsageReportRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateCustomerMonthlyUsageReportWithHttpInfoAsync(customerMonthlyUsageReportRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Start the customer monthly usage report generation
        /// </summary>
        /// <remarks>
        /// Starts generating a customer monthly usage report as an xlsx file and saves it in Documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerMonthlyUsageReportRequestDto">The request parameters for generating a customer monthly usage report. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-monthly-usage-report/">REST API Reference for CreateCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>Task of ApiResponse (DocumentBuilderTaskWrapper)</returns>
        public async Task<ApiResponse<DocumentBuilderTaskWrapper>> CreateCustomerMonthlyUsageReportWithHttpInfoAsync(CustomerMonthlyUsageReportRequestDto? customerMonthlyUsageReportRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (customerMonthlyUsageReportRequestDto != null) localVarRequestOptions.Data = customerMonthlyUsageReportRequestDto;

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

            var localVarResponse = await AsynchronousClient.PostAsync<DocumentBuilderTaskWrapper>("/api/2.0/portal/payment/customer/usage/monthly/report", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateCustomerMonthlyUsageReport", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Start the customer operations report generation
        /// </summary>
        /// <remarks>
        /// Starts generating a customer operations report as an xlsx file and saves it in Documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerOperationsReportRequestDto">The request parameters for generating a report on client operations. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-operations-report/">REST API Reference for CreateCustomerOperationsReport Operation</seealso>
        /// <returns>DocumentBuilderTaskWrapper</returns>
        public DocumentBuilderTaskWrapper CreateCustomerOperationsReport(CustomerOperationsReportRequestDto? customerOperationsReportRequestDto = default)
        {
            var localVarResponse = CreateCustomerOperationsReportWithHttpInfo(customerOperationsReportRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Start the customer operations report generation
        /// </summary>
        /// <remarks>
        /// Starts generating a customer operations report as an xlsx file and saves it in Documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerOperationsReportRequestDto">The request parameters for generating a report on client operations. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-operations-report/">REST API Reference for CreateCustomerOperationsReport Operation</seealso>
        /// <returns>ApiResponse of DocumentBuilderTaskWrapper</returns>
        public ApiResponse<DocumentBuilderTaskWrapper> CreateCustomerOperationsReportWithHttpInfo(CustomerOperationsReportRequestDto? customerOperationsReportRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (customerOperationsReportRequestDto != null) localVarRequestOptions.Data = customerOperationsReportRequestDto;

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
            var localVarResponse = Client.Post<DocumentBuilderTaskWrapper>("/api/2.0/portal/payment/customer/operationsreport", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateCustomerOperationsReport", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Start the customer operations report generation
        /// </summary>
        /// <remarks>
        /// Starts generating a customer operations report as an xlsx file and saves it in Documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerOperationsReportRequestDto">The request parameters for generating a report on client operations. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-operations-report/">REST API Reference for CreateCustomerOperationsReport Operation</seealso>
        /// <returns>Task of DocumentBuilderTaskWrapper</returns>
        public async Task<DocumentBuilderTaskWrapper> CreateCustomerOperationsReportAsync(CustomerOperationsReportRequestDto? customerOperationsReportRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateCustomerOperationsReportWithHttpInfoAsync(customerOperationsReportRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Start the customer operations report generation
        /// </summary>
        /// <remarks>
        /// Starts generating a customer operations report as an xlsx file and saves it in Documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerOperationsReportRequestDto">The request parameters for generating a report on client operations. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-operations-report/">REST API Reference for CreateCustomerOperationsReport Operation</seealso>
        /// <returns>Task of ApiResponse (DocumentBuilderTaskWrapper)</returns>
        public async Task<ApiResponse<DocumentBuilderTaskWrapper>> CreateCustomerOperationsReportWithHttpInfoAsync(CustomerOperationsReportRequestDto? customerOperationsReportRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (customerOperationsReportRequestDto != null) localVarRequestOptions.Data = customerOperationsReportRequestDto;

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

            var localVarResponse = await AsynchronousClient.PostAsync<DocumentBuilderTaskWrapper>("/api/2.0/portal/payment/customer/operationsreport", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateCustomerOperationsReport", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Start the customer service usage report generation
        /// </summary>
        /// <remarks>
        /// Starts generating a customer service usage report as an xlsx file and saves it in Documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerServiceUsageReportRequestDto">The request parameters for generating a customer service usage report. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-service-usage-report/">REST API Reference for CreateCustomerServiceUsageReport Operation</seealso>
        /// <returns>DocumentBuilderTaskWrapper</returns>
        public DocumentBuilderTaskWrapper CreateCustomerServiceUsageReport(CustomerServiceUsageReportRequestDto? customerServiceUsageReportRequestDto = default)
        {
            var localVarResponse = CreateCustomerServiceUsageReportWithHttpInfo(customerServiceUsageReportRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Start the customer service usage report generation
        /// </summary>
        /// <remarks>
        /// Starts generating a customer service usage report as an xlsx file and saves it in Documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerServiceUsageReportRequestDto">The request parameters for generating a customer service usage report. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-service-usage-report/">REST API Reference for CreateCustomerServiceUsageReport Operation</seealso>
        /// <returns>ApiResponse of DocumentBuilderTaskWrapper</returns>
        public ApiResponse<DocumentBuilderTaskWrapper> CreateCustomerServiceUsageReportWithHttpInfo(CustomerServiceUsageReportRequestDto? customerServiceUsageReportRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (customerServiceUsageReportRequestDto != null) localVarRequestOptions.Data = customerServiceUsageReportRequestDto;

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
            var localVarResponse = Client.Post<DocumentBuilderTaskWrapper>("/api/2.0/portal/payment/customer/usage/report", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateCustomerServiceUsageReport", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Start the customer service usage report generation
        /// </summary>
        /// <remarks>
        /// Starts generating a customer service usage report as an xlsx file and saves it in Documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerServiceUsageReportRequestDto">The request parameters for generating a customer service usage report. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-service-usage-report/">REST API Reference for CreateCustomerServiceUsageReport Operation</seealso>
        /// <returns>Task of DocumentBuilderTaskWrapper</returns>
        public async Task<DocumentBuilderTaskWrapper> CreateCustomerServiceUsageReportAsync(CustomerServiceUsageReportRequestDto? customerServiceUsageReportRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateCustomerServiceUsageReportWithHttpInfoAsync(customerServiceUsageReportRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Start the customer service usage report generation
        /// </summary>
        /// <remarks>
        /// Starts generating a customer service usage report as an xlsx file and saves it in Documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerServiceUsageReportRequestDto">The request parameters for generating a customer service usage report. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-service-usage-report/">REST API Reference for CreateCustomerServiceUsageReport Operation</seealso>
        /// <returns>Task of ApiResponse (DocumentBuilderTaskWrapper)</returns>
        public async Task<ApiResponse<DocumentBuilderTaskWrapper>> CreateCustomerServiceUsageReportWithHttpInfoAsync(CustomerServiceUsageReportRequestDto? customerServiceUsageReportRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (customerServiceUsageReportRequestDto != null) localVarRequestOptions.Data = customerServiceUsageReportRequestDto;

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

            var localVarResponse = await AsynchronousClient.PostAsync<DocumentBuilderTaskWrapper>("/api/2.0/portal/payment/customer/usage/report", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateCustomerServiceUsageReport", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Credit AI balance
        /// </summary>
        /// <remarks>
        /// Credits AI quota to the customer AI sub-account from their main balance.  Requires the customer to have a configured payment method.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="creditAiBalanceRequestDto">The request parameters for crediting AI quota to the customer AI subaccount. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/credit-ai-balance/">REST API Reference for CreditAiBalance Operation</seealso>
        /// <returns>ServicePaymentWrapper</returns>
        public ServicePaymentWrapper CreditAiBalance(CreditAiBalanceRequestDto? creditAiBalanceRequestDto = default)
        {
            var localVarResponse = CreditAiBalanceWithHttpInfo(creditAiBalanceRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Credit AI balance
        /// </summary>
        /// <remarks>
        /// Credits AI quota to the customer AI sub-account from their main balance.  Requires the customer to have a configured payment method.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="creditAiBalanceRequestDto">The request parameters for crediting AI quota to the customer AI subaccount. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/credit-ai-balance/">REST API Reference for CreditAiBalance Operation</seealso>
        /// <returns>ApiResponse of ServicePaymentWrapper</returns>
        public ApiResponse<ServicePaymentWrapper> CreditAiBalanceWithHttpInfo(CreditAiBalanceRequestDto? creditAiBalanceRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (creditAiBalanceRequestDto != null) localVarRequestOptions.Data = creditAiBalanceRequestDto;

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
            var localVarResponse = Client.Post<ServicePaymentWrapper>("/api/2.0/portal/payment/creditaibalance", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreditAiBalance", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Credit AI balance
        /// </summary>
        /// <remarks>
        /// Credits AI quota to the customer AI sub-account from their main balance.  Requires the customer to have a configured payment method.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="creditAiBalanceRequestDto">The request parameters for crediting AI quota to the customer AI subaccount. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/credit-ai-balance/">REST API Reference for CreditAiBalance Operation</seealso>
        /// <returns>Task of ServicePaymentWrapper</returns>
        public async Task<ServicePaymentWrapper> CreditAiBalanceAsync(CreditAiBalanceRequestDto? creditAiBalanceRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreditAiBalanceWithHttpInfoAsync(creditAiBalanceRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Credit AI balance
        /// </summary>
        /// <remarks>
        /// Credits AI quota to the customer AI sub-account from their main balance.  Requires the customer to have a configured payment method.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="creditAiBalanceRequestDto">The request parameters for crediting AI quota to the customer AI subaccount. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/credit-ai-balance/">REST API Reference for CreditAiBalance Operation</seealso>
        /// <returns>Task of ApiResponse (ServicePaymentWrapper)</returns>
        public async Task<ApiResponse<ServicePaymentWrapper>> CreditAiBalanceWithHttpInfoAsync(CreditAiBalanceRequestDto? creditAiBalanceRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (creditAiBalanceRequestDto != null) localVarRequestOptions.Data = creditAiBalanceRequestDto;

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

            var localVarResponse = await AsynchronousClient.PostAsync<ServicePaymentWrapper>("/api/2.0/portal/payment/creditaibalance", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreditAiBalance", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get AI model prices
        /// </summary>
        /// <remarks>
        /// Retrieves the pricing information for AI models including chat, embedding, and web search services.  The prices are returned in the configured currency and normalized per million tokens.  Requires administrator permissions to access.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-ai-prices/">REST API Reference for GetAiPrices Operation</seealso>
        /// <returns>AiPricesResponseWrapper</returns>
        public AiPricesResponseWrapper GetAiPrices()
        {
            var localVarResponse = GetAiPricesWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get AI model prices
        /// </summary>
        /// <remarks>
        /// Retrieves the pricing information for AI models including chat, embedding, and web search services.  The prices are returned in the configured currency and normalized per million tokens.  Requires administrator permissions to access.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-ai-prices/">REST API Reference for GetAiPrices Operation</seealso>
        /// <returns>ApiResponse of AiPricesResponseWrapper</returns>
        public ApiResponse<AiPricesResponseWrapper> GetAiPricesWithHttpInfo()
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
            var localVarResponse = Client.Get<AiPricesResponseWrapper>("/api/2.0/portal/payment/ai-prices", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAiPrices", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get AI model prices
        /// </summary>
        /// <remarks>
        /// Retrieves the pricing information for AI models including chat, embedding, and web search services.  The prices are returned in the configured currency and normalized per million tokens.  Requires administrator permissions to access.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-ai-prices/">REST API Reference for GetAiPrices Operation</seealso>
        /// <returns>Task of AiPricesResponseWrapper</returns>
        public async Task<AiPricesResponseWrapper> GetAiPricesAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetAiPricesWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get AI model prices
        /// </summary>
        /// <remarks>
        /// Retrieves the pricing information for AI models including chat, embedding, and web search services.  The prices are returned in the configured currency and normalized per million tokens.  Requires administrator permissions to access.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-ai-prices/">REST API Reference for GetAiPrices Operation</seealso>
        /// <returns>Task of ApiResponse (AiPricesResponseWrapper)</returns>
        public async Task<ApiResponse<AiPricesResponseWrapper>> GetAiPricesWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<AiPricesResponseWrapper>("/api/2.0/portal/payment/ai-prices", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAiPrices", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the checkout setup page URL
        /// </summary>
        /// <remarks>
        /// Returns the URL to the checkout setup page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">The URL where the user will be redirected after setup cancellation.</param>
        /// <param name="successUrl">The URL where the user will be redirected after successful payment.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-checkout-setup-url/">REST API Reference for GetCheckoutSetupUrl Operation</seealso>
        /// <returns>StringWrapper</returns>
        public StringWrapper GetCheckoutSetupUrl(string backUrl, string successUrl)
        {
            var localVarResponse = GetCheckoutSetupUrlWithHttpInfo(backUrl, successUrl);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the checkout setup page URL
        /// </summary>
        /// <remarks>
        /// Returns the URL to the checkout setup page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">The URL where the user will be redirected after setup cancellation.</param>
        /// <param name="successUrl">The URL where the user will be redirected after successful payment.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-checkout-setup-url/">REST API Reference for GetCheckoutSetupUrl Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        public ApiResponse<StringWrapper> GetCheckoutSetupUrlWithHttpInfo(string backUrl, string successUrl)
        {
            // verify the required parameter 'backUrl' is set
            if (backUrl == null)
                throw new ApiException(400, "Missing required parameter 'backUrl' when calling PaymentApi->GetCheckoutSetupUrl");

            // verify the required parameter 'successUrl' is set
            if (successUrl == null)
                throw new ApiException(400, "Missing required parameter 'successUrl' when calling PaymentApi->GetCheckoutSetupUrl");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "BackUrl", backUrl));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "SuccessUrl", successUrl));

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
            var localVarResponse = Client.Get<StringWrapper>("/api/2.0/portal/payment/checkoutsetupurl", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetCheckoutSetupUrl", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the checkout setup page URL
        /// </summary>
        /// <remarks>
        /// Returns the URL to the checkout setup page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">The URL where the user will be redirected after setup cancellation.</param>
        /// <param name="successUrl">The URL where the user will be redirected after successful payment.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-checkout-setup-url/">REST API Reference for GetCheckoutSetupUrl Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        public async Task<StringWrapper> GetCheckoutSetupUrlAsync(string backUrl, string successUrl, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetCheckoutSetupUrlWithHttpInfoAsync(backUrl, successUrl, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the checkout setup page URL
        /// </summary>
        /// <remarks>
        /// Returns the URL to the checkout setup page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">The URL where the user will be redirected after setup cancellation.</param>
        /// <param name="successUrl">The URL where the user will be redirected after successful payment.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-checkout-setup-url/">REST API Reference for GetCheckoutSetupUrl Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        public async Task<ApiResponse<StringWrapper>> GetCheckoutSetupUrlWithHttpInfoAsync(string backUrl, string successUrl, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'backUrl' is set
            if (backUrl == null)
                throw new ApiException(400, "Missing required parameter 'backUrl' when calling PaymentApi->GetCheckoutSetupUrl");

            // verify the required parameter 'successUrl' is set
            if (successUrl == null)
                throw new ApiException(400, "Missing required parameter 'successUrl' when calling PaymentApi->GetCheckoutSetupUrl");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "BackUrl", backUrl));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "SuccessUrl", successUrl));

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

            var localVarResponse = await AsynchronousClient.GetAsync<StringWrapper>("/api/2.0/portal/payment/checkoutsetupurl", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetCheckoutSetupUrl", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the customer AI balance
        /// </summary>
        /// <remarks>
        /// Returns the AI quota balance of a customer from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-ai-balance/">REST API Reference for GetCustomerAiBalance Operation</seealso>
        /// <returns>BalanceWrapper</returns>
        public BalanceWrapper GetCustomerAiBalance(bool? refresh = default)
        {
            var localVarResponse = GetCustomerAiBalanceWithHttpInfo(refresh);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the customer AI balance
        /// </summary>
        /// <remarks>
        /// Returns the AI quota balance of a customer from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-ai-balance/">REST API Reference for GetCustomerAiBalance Operation</seealso>
        /// <returns>ApiResponse of BalanceWrapper</returns>
        public ApiResponse<BalanceWrapper> GetCustomerAiBalanceWithHttpInfo(bool? refresh = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (refresh != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "refresh", refresh));
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
            var localVarResponse = Client.Get<BalanceWrapper>("/api/2.0/portal/payment/customer/aibalance", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetCustomerAiBalance", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the customer AI balance
        /// </summary>
        /// <remarks>
        /// Returns the AI quota balance of a customer from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-ai-balance/">REST API Reference for GetCustomerAiBalance Operation</seealso>
        /// <returns>Task of BalanceWrapper</returns>
        public async Task<BalanceWrapper> GetCustomerAiBalanceAsync(bool? refresh = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetCustomerAiBalanceWithHttpInfoAsync(refresh, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the customer AI balance
        /// </summary>
        /// <remarks>
        /// Returns the AI quota balance of a customer from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-ai-balance/">REST API Reference for GetCustomerAiBalance Operation</seealso>
        /// <returns>Task of ApiResponse (BalanceWrapper)</returns>
        public async Task<ApiResponse<BalanceWrapper>> GetCustomerAiBalanceWithHttpInfoAsync(bool? refresh = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (refresh != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "refresh", refresh));
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

            var localVarResponse = await AsynchronousClient.GetAsync<BalanceWrapper>("/api/2.0/portal/payment/customer/aibalance", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetCustomerAiBalance", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the customer balance
        /// </summary>
        /// <remarks>
        /// Returns the customer balance from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-balance/">REST API Reference for GetCustomerBalance Operation</seealso>
        /// <returns>BalanceWrapper</returns>
        public BalanceWrapper GetCustomerBalance(bool? refresh = default)
        {
            var localVarResponse = GetCustomerBalanceWithHttpInfo(refresh);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the customer balance
        /// </summary>
        /// <remarks>
        /// Returns the customer balance from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-balance/">REST API Reference for GetCustomerBalance Operation</seealso>
        /// <returns>ApiResponse of BalanceWrapper</returns>
        public ApiResponse<BalanceWrapper> GetCustomerBalanceWithHttpInfo(bool? refresh = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (refresh != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "refresh", refresh));
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
            var localVarResponse = Client.Get<BalanceWrapper>("/api/2.0/portal/payment/customer/balance", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetCustomerBalance", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the customer balance
        /// </summary>
        /// <remarks>
        /// Returns the customer balance from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-balance/">REST API Reference for GetCustomerBalance Operation</seealso>
        /// <returns>Task of BalanceWrapper</returns>
        public async Task<BalanceWrapper> GetCustomerBalanceAsync(bool? refresh = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetCustomerBalanceWithHttpInfoAsync(refresh, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the customer balance
        /// </summary>
        /// <remarks>
        /// Returns the customer balance from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-balance/">REST API Reference for GetCustomerBalance Operation</seealso>
        /// <returns>Task of ApiResponse (BalanceWrapper)</returns>
        public async Task<ApiResponse<BalanceWrapper>> GetCustomerBalanceWithHttpInfoAsync(bool? refresh = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (refresh != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "refresh", refresh));
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

            var localVarResponse = await AsynchronousClient.GetAsync<BalanceWrapper>("/api/2.0/portal/payment/customer/balance", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetCustomerBalance", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the customer information
        /// </summary>
        /// <remarks>
        /// Returns the customer information.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-info/">REST API Reference for GetCustomerInfo Operation</seealso>
        /// <returns>CustomerInfoWrapper</returns>
        public CustomerInfoWrapper GetCustomerInfo(bool? refresh = default)
        {
            var localVarResponse = GetCustomerInfoWithHttpInfo(refresh);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the customer information
        /// </summary>
        /// <remarks>
        /// Returns the customer information.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-info/">REST API Reference for GetCustomerInfo Operation</seealso>
        /// <returns>ApiResponse of CustomerInfoWrapper</returns>
        public ApiResponse<CustomerInfoWrapper> GetCustomerInfoWithHttpInfo(bool? refresh = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (refresh != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "refresh", refresh));
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
            var localVarResponse = Client.Get<CustomerInfoWrapper>("/api/2.0/portal/payment/customerinfo", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetCustomerInfo", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the customer information
        /// </summary>
        /// <remarks>
        /// Returns the customer information.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-info/">REST API Reference for GetCustomerInfo Operation</seealso>
        /// <returns>Task of CustomerInfoWrapper</returns>
        public async Task<CustomerInfoWrapper> GetCustomerInfoAsync(bool? refresh = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetCustomerInfoWithHttpInfoAsync(refresh, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the customer information
        /// </summary>
        /// <remarks>
        /// Returns the customer information.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-info/">REST API Reference for GetCustomerInfo Operation</seealso>
        /// <returns>Task of ApiResponse (CustomerInfoWrapper)</returns>
        public async Task<ApiResponse<CustomerInfoWrapper>> GetCustomerInfoWithHttpInfoAsync(bool? refresh = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (refresh != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "refresh", refresh));
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

            var localVarResponse = await AsynchronousClient.GetAsync<CustomerInfoWrapper>("/api/2.0/portal/payment/customerinfo", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetCustomerInfo", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the customer monthly usage
        /// </summary>
        /// <remarks>
        /// Returns the customer spending aggregated per calendar month from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Start of the period (inclusive). (optional)</param>
        /// <param name="endDate">End of the period (inclusive). (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-monthly-usage/">REST API Reference for GetCustomerMonthlyUsage Operation</seealso>
        /// <returns>CustomerMonthlyUsageArrayWrapper</returns>
        public CustomerMonthlyUsageArrayWrapper GetCustomerMonthlyUsage(DateTime? startDate = default, DateTime? endDate = default)
        {
            var localVarResponse = GetCustomerMonthlyUsageWithHttpInfo(startDate, endDate);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the customer monthly usage
        /// </summary>
        /// <remarks>
        /// Returns the customer spending aggregated per calendar month from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Start of the period (inclusive). (optional)</param>
        /// <param name="endDate">End of the period (inclusive). (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-monthly-usage/">REST API Reference for GetCustomerMonthlyUsage Operation</seealso>
        /// <returns>ApiResponse of CustomerMonthlyUsageArrayWrapper</returns>
        public ApiResponse<CustomerMonthlyUsageArrayWrapper> GetCustomerMonthlyUsageWithHttpInfo(DateTime? startDate = default, DateTime? endDate = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (startDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startDate", startDate));
            }
            if (endDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "endDate", endDate));
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
            var localVarResponse = Client.Get<CustomerMonthlyUsageArrayWrapper>("/api/2.0/portal/payment/customer/usage/monthly", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetCustomerMonthlyUsage", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the customer monthly usage
        /// </summary>
        /// <remarks>
        /// Returns the customer spending aggregated per calendar month from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Start of the period (inclusive). (optional)</param>
        /// <param name="endDate">End of the period (inclusive). (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-monthly-usage/">REST API Reference for GetCustomerMonthlyUsage Operation</seealso>
        /// <returns>Task of CustomerMonthlyUsageArrayWrapper</returns>
        public async Task<CustomerMonthlyUsageArrayWrapper> GetCustomerMonthlyUsageAsync(DateTime? startDate = default, DateTime? endDate = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetCustomerMonthlyUsageWithHttpInfoAsync(startDate, endDate, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the customer monthly usage
        /// </summary>
        /// <remarks>
        /// Returns the customer spending aggregated per calendar month from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Start of the period (inclusive). (optional)</param>
        /// <param name="endDate">End of the period (inclusive). (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-monthly-usage/">REST API Reference for GetCustomerMonthlyUsage Operation</seealso>
        /// <returns>Task of ApiResponse (CustomerMonthlyUsageArrayWrapper)</returns>
        public async Task<ApiResponse<CustomerMonthlyUsageArrayWrapper>> GetCustomerMonthlyUsageWithHttpInfoAsync(DateTime? startDate = default, DateTime? endDate = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (startDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startDate", startDate));
            }
            if (endDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "endDate", endDate));
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

            var localVarResponse = await AsynchronousClient.GetAsync<CustomerMonthlyUsageArrayWrapper>("/api/2.0/portal/payment/customer/usage/monthly", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetCustomerMonthlyUsage", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the status of the customer monthly usage report generation
        /// </summary>
        /// <remarks>
        /// Returns the status of generating a customer monthly usage report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-monthly-usage-report/">REST API Reference for GetCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>DocumentBuilderTaskWrapper</returns>
        public DocumentBuilderTaskWrapper GetCustomerMonthlyUsageReport()
        {
            var localVarResponse = GetCustomerMonthlyUsageReportWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the status of the customer monthly usage report generation
        /// </summary>
        /// <remarks>
        /// Returns the status of generating a customer monthly usage report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-monthly-usage-report/">REST API Reference for GetCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>ApiResponse of DocumentBuilderTaskWrapper</returns>
        public ApiResponse<DocumentBuilderTaskWrapper> GetCustomerMonthlyUsageReportWithHttpInfo()
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
            var localVarResponse = Client.Get<DocumentBuilderTaskWrapper>("/api/2.0/portal/payment/customer/usage/monthly/report", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetCustomerMonthlyUsageReport", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the status of the customer monthly usage report generation
        /// </summary>
        /// <remarks>
        /// Returns the status of generating a customer monthly usage report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-monthly-usage-report/">REST API Reference for GetCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>Task of DocumentBuilderTaskWrapper</returns>
        public async Task<DocumentBuilderTaskWrapper> GetCustomerMonthlyUsageReportAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetCustomerMonthlyUsageReportWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the status of the customer monthly usage report generation
        /// </summary>
        /// <remarks>
        /// Returns the status of generating a customer monthly usage report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-monthly-usage-report/">REST API Reference for GetCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>Task of ApiResponse (DocumentBuilderTaskWrapper)</returns>
        public async Task<ApiResponse<DocumentBuilderTaskWrapper>> GetCustomerMonthlyUsageReportWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<DocumentBuilderTaskWrapper>("/api/2.0/portal/payment/customer/usage/monthly/report", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetCustomerMonthlyUsageReport", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the customer operations
        /// </summary>
        /// <remarks>
        /// Returns the report of customer operations from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">The number of items to skip for pagination. The default value is 0. (optional)</param>
        /// <param name="limit">The maximum number of items to return for pagination. The default value is 25. (optional)</param>
        /// <param name="serviceName">The service name list. A single string is also accepted for backward compatibility. (optional)</param>
        /// <param name="startDate">The report start date. (optional)</param>
        /// <param name="endDate">The report end date. (optional)</param>
        /// <param name="participantName">The participant name. (optional)</param>
        /// <param name="credit">Specifies whether to include credit operations in the report. (optional)</param>
        /// <param name="debit">Specifies whether to include debit operations in the report. (optional)</param>
        /// <param name="type">The operation type to filter by. (optional)</param>
        /// <param name="status">The operation status to filter by. (optional)</param>
        /// <param name="orderBy">The field to order by. (optional)</param>
        /// <param name="orderType">Order direction: Ascending or Descending. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-operations/">REST API Reference for GetCustomerOperations Operation</seealso>
        /// <returns>ReportWrapper</returns>
        public ReportWrapper GetCustomerOperations(int? offset = default, int? limit = default, List<string>? serviceName = default, DateTime? startDate = default, DateTime? endDate = default, string? participantName = default, bool? credit = default, bool? debit = default, OperationType? type = default, OperationStatus? status = default, string? orderBy = default, OperationOrderType? orderType = default)
        {
            var localVarResponse = GetCustomerOperationsWithHttpInfo(offset, limit, serviceName, startDate, endDate, participantName, credit, debit, type, status, orderBy, orderType);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the customer operations
        /// </summary>
        /// <remarks>
        /// Returns the report of customer operations from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">The number of items to skip for pagination. The default value is 0. (optional)</param>
        /// <param name="limit">The maximum number of items to return for pagination. The default value is 25. (optional)</param>
        /// <param name="serviceName">The service name list. A single string is also accepted for backward compatibility. (optional)</param>
        /// <param name="startDate">The report start date. (optional)</param>
        /// <param name="endDate">The report end date. (optional)</param>
        /// <param name="participantName">The participant name. (optional)</param>
        /// <param name="credit">Specifies whether to include credit operations in the report. (optional)</param>
        /// <param name="debit">Specifies whether to include debit operations in the report. (optional)</param>
        /// <param name="type">The operation type to filter by. (optional)</param>
        /// <param name="status">The operation status to filter by. (optional)</param>
        /// <param name="orderBy">The field to order by. (optional)</param>
        /// <param name="orderType">Order direction: Ascending or Descending. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-operations/">REST API Reference for GetCustomerOperations Operation</seealso>
        /// <returns>ApiResponse of ReportWrapper</returns>
        public ApiResponse<ReportWrapper> GetCustomerOperationsWithHttpInfo(int? offset = default, int? limit = default, List<string>? serviceName = default, DateTime? startDate = default, DateTime? endDate = default, string? participantName = default, bool? credit = default, bool? debit = default, OperationType? type = default, OperationStatus? status = default, string? orderBy = default, OperationOrderType? orderType = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (offset != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "offset", offset));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (serviceName != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("multi", "ServiceName", serviceName));
            }
            if (startDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "StartDate", startDate));
            }
            if (endDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "EndDate", endDate));
            }
            if (participantName != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "ParticipantName", participantName));
            }
            if (credit != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Credit", credit));
            }
            if (debit != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Debit", debit));
            }
            if (type != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Type", type));
            }
            if (status != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Status", status));
            }
            if (orderBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "OrderBy", orderBy));
            }
            if (orderType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "OrderType", orderType));
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
            var localVarResponse = Client.Get<ReportWrapper>("/api/2.0/portal/payment/customer/operations", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetCustomerOperations", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the customer operations
        /// </summary>
        /// <remarks>
        /// Returns the report of customer operations from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">The number of items to skip for pagination. The default value is 0. (optional)</param>
        /// <param name="limit">The maximum number of items to return for pagination. The default value is 25. (optional)</param>
        /// <param name="serviceName">The service name list. A single string is also accepted for backward compatibility. (optional)</param>
        /// <param name="startDate">The report start date. (optional)</param>
        /// <param name="endDate">The report end date. (optional)</param>
        /// <param name="participantName">The participant name. (optional)</param>
        /// <param name="credit">Specifies whether to include credit operations in the report. (optional)</param>
        /// <param name="debit">Specifies whether to include debit operations in the report. (optional)</param>
        /// <param name="type">The operation type to filter by. (optional)</param>
        /// <param name="status">The operation status to filter by. (optional)</param>
        /// <param name="orderBy">The field to order by. (optional)</param>
        /// <param name="orderType">Order direction: Ascending or Descending. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-operations/">REST API Reference for GetCustomerOperations Operation</seealso>
        /// <returns>Task of ReportWrapper</returns>
        public async Task<ReportWrapper> GetCustomerOperationsAsync(int? offset = default, int? limit = default, List<string>? serviceName = default, DateTime? startDate = default, DateTime? endDate = default, string? participantName = default, bool? credit = default, bool? debit = default, OperationType? type = default, OperationStatus? status = default, string? orderBy = default, OperationOrderType? orderType = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetCustomerOperationsWithHttpInfoAsync(offset, limit, serviceName, startDate, endDate, participantName, credit, debit, type, status, orderBy, orderType, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the customer operations
        /// </summary>
        /// <remarks>
        /// Returns the report of customer operations from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">The number of items to skip for pagination. The default value is 0. (optional)</param>
        /// <param name="limit">The maximum number of items to return for pagination. The default value is 25. (optional)</param>
        /// <param name="serviceName">The service name list. A single string is also accepted for backward compatibility. (optional)</param>
        /// <param name="startDate">The report start date. (optional)</param>
        /// <param name="endDate">The report end date. (optional)</param>
        /// <param name="participantName">The participant name. (optional)</param>
        /// <param name="credit">Specifies whether to include credit operations in the report. (optional)</param>
        /// <param name="debit">Specifies whether to include debit operations in the report. (optional)</param>
        /// <param name="type">The operation type to filter by. (optional)</param>
        /// <param name="status">The operation status to filter by. (optional)</param>
        /// <param name="orderBy">The field to order by. (optional)</param>
        /// <param name="orderType">Order direction: Ascending or Descending. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-operations/">REST API Reference for GetCustomerOperations Operation</seealso>
        /// <returns>Task of ApiResponse (ReportWrapper)</returns>
        public async Task<ApiResponse<ReportWrapper>> GetCustomerOperationsWithHttpInfoAsync(int? offset = default, int? limit = default, List<string>? serviceName = default, DateTime? startDate = default, DateTime? endDate = default, string? participantName = default, bool? credit = default, bool? debit = default, OperationType? type = default, OperationStatus? status = default, string? orderBy = default, OperationOrderType? orderType = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (offset != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "offset", offset));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (serviceName != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("multi", "ServiceName", serviceName));
            }
            if (startDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "StartDate", startDate));
            }
            if (endDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "EndDate", endDate));
            }
            if (participantName != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "ParticipantName", participantName));
            }
            if (credit != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Credit", credit));
            }
            if (debit != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Debit", debit));
            }
            if (type != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Type", type));
            }
            if (status != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Status", status));
            }
            if (orderBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "OrderBy", orderBy));
            }
            if (orderType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "OrderType", orderType));
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

            var localVarResponse = await AsynchronousClient.GetAsync<ReportWrapper>("/api/2.0/portal/payment/customer/operations", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetCustomerOperations", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the status of the customer operations report generation
        /// </summary>
        /// <remarks>
        /// Returns the status of generating a customer operations report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-operations-report/">REST API Reference for GetCustomerOperationsReport Operation</seealso>
        /// <returns>DocumentBuilderTaskWrapper</returns>
        public DocumentBuilderTaskWrapper GetCustomerOperationsReport()
        {
            var localVarResponse = GetCustomerOperationsReportWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the status of the customer operations report generation
        /// </summary>
        /// <remarks>
        /// Returns the status of generating a customer operations report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-operations-report/">REST API Reference for GetCustomerOperationsReport Operation</seealso>
        /// <returns>ApiResponse of DocumentBuilderTaskWrapper</returns>
        public ApiResponse<DocumentBuilderTaskWrapper> GetCustomerOperationsReportWithHttpInfo()
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
            var localVarResponse = Client.Get<DocumentBuilderTaskWrapper>("/api/2.0/portal/payment/customer/operationsreport", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetCustomerOperationsReport", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the status of the customer operations report generation
        /// </summary>
        /// <remarks>
        /// Returns the status of generating a customer operations report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-operations-report/">REST API Reference for GetCustomerOperationsReport Operation</seealso>
        /// <returns>Task of DocumentBuilderTaskWrapper</returns>
        public async Task<DocumentBuilderTaskWrapper> GetCustomerOperationsReportAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetCustomerOperationsReportWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the status of the customer operations report generation
        /// </summary>
        /// <remarks>
        /// Returns the status of generating a customer operations report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-operations-report/">REST API Reference for GetCustomerOperationsReport Operation</seealso>
        /// <returns>Task of ApiResponse (DocumentBuilderTaskWrapper)</returns>
        public async Task<ApiResponse<DocumentBuilderTaskWrapper>> GetCustomerOperationsReportWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<DocumentBuilderTaskWrapper>("/api/2.0/portal/payment/customer/operationsreport", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetCustomerOperationsReport", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the customer service usage
        /// </summary>
        /// <remarks>
        /// Returns the customer usage statistics aggregated per service from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName">The service name list. (optional)</param>
        /// <param name="participantName">The participant name. (optional)</param>
        /// <param name="status">The operation status to filter by. (optional)</param>
        /// <param name="startDate">Start of the period (inclusive). (optional)</param>
        /// <param name="endDate">End of the period (inclusive). (optional)</param>
        /// <param name="metadata">Metadata key-value pairs to filter by. (optional)</param>
        /// <param name="offset">The number of items to skip for pagination. The default value is 0. (optional)</param>
        /// <param name="limit">The maximum number of items to return for pagination. The default value is 25. (optional)</param>
        /// <param name="orderBy">The field to order by. (optional)</param>
        /// <param name="orderType">Order direction: Ascending or Descending. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-service-usage/">REST API Reference for GetCustomerServiceUsage Operation</seealso>
        /// <returns>CustomerServiceUsageReportWrapper</returns>
        public CustomerServiceUsageReportWrapper GetCustomerServiceUsage(List<string>? serviceName = default, string? participantName = default, OperationStatus? status = default, DateTime? startDate = default, DateTime? endDate = default, Dictionary<string, string>? metadata = default, int? offset = default, int? limit = default, string? orderBy = default, OperationOrderType? orderType = default)
        {
            var localVarResponse = GetCustomerServiceUsageWithHttpInfo(serviceName, participantName, status, startDate, endDate, metadata, offset, limit, orderBy, orderType);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the customer service usage
        /// </summary>
        /// <remarks>
        /// Returns the customer usage statistics aggregated per service from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName">The service name list. (optional)</param>
        /// <param name="participantName">The participant name. (optional)</param>
        /// <param name="status">The operation status to filter by. (optional)</param>
        /// <param name="startDate">Start of the period (inclusive). (optional)</param>
        /// <param name="endDate">End of the period (inclusive). (optional)</param>
        /// <param name="metadata">Metadata key-value pairs to filter by. (optional)</param>
        /// <param name="offset">The number of items to skip for pagination. The default value is 0. (optional)</param>
        /// <param name="limit">The maximum number of items to return for pagination. The default value is 25. (optional)</param>
        /// <param name="orderBy">The field to order by. (optional)</param>
        /// <param name="orderType">Order direction: Ascending or Descending. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-service-usage/">REST API Reference for GetCustomerServiceUsage Operation</seealso>
        /// <returns>ApiResponse of CustomerServiceUsageReportWrapper</returns>
        public ApiResponse<CustomerServiceUsageReportWrapper> GetCustomerServiceUsageWithHttpInfo(List<string>? serviceName = default, string? participantName = default, OperationStatus? status = default, DateTime? startDate = default, DateTime? endDate = default, Dictionary<string, string>? metadata = default, int? offset = default, int? limit = default, string? orderBy = default, OperationOrderType? orderType = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (serviceName != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("multi", "ServiceName", serviceName));
            }
            if (participantName != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "ParticipantName", participantName));
            }
            if (status != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Status", status));
            }
            if (startDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "StartDate", startDate));
            }
            if (endDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "EndDate", endDate));
            }
            if (metadata != null)
            {
            }
            if (offset != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "offset", offset));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (orderBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "OrderBy", orderBy));
            }
            if (orderType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "OrderType", orderType));
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
            var localVarResponse = Client.Get<CustomerServiceUsageReportWrapper>("/api/2.0/portal/payment/customer/usage", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetCustomerServiceUsage", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the customer service usage
        /// </summary>
        /// <remarks>
        /// Returns the customer usage statistics aggregated per service from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName">The service name list. (optional)</param>
        /// <param name="participantName">The participant name. (optional)</param>
        /// <param name="status">The operation status to filter by. (optional)</param>
        /// <param name="startDate">Start of the period (inclusive). (optional)</param>
        /// <param name="endDate">End of the period (inclusive). (optional)</param>
        /// <param name="metadata">Metadata key-value pairs to filter by. (optional)</param>
        /// <param name="offset">The number of items to skip for pagination. The default value is 0. (optional)</param>
        /// <param name="limit">The maximum number of items to return for pagination. The default value is 25. (optional)</param>
        /// <param name="orderBy">The field to order by. (optional)</param>
        /// <param name="orderType">Order direction: Ascending or Descending. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-service-usage/">REST API Reference for GetCustomerServiceUsage Operation</seealso>
        /// <returns>Task of CustomerServiceUsageReportWrapper</returns>
        public async Task<CustomerServiceUsageReportWrapper> GetCustomerServiceUsageAsync(List<string>? serviceName = default, string? participantName = default, OperationStatus? status = default, DateTime? startDate = default, DateTime? endDate = default, Dictionary<string, string>? metadata = default, int? offset = default, int? limit = default, string? orderBy = default, OperationOrderType? orderType = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetCustomerServiceUsageWithHttpInfoAsync(serviceName, participantName, status, startDate, endDate, metadata, offset, limit, orderBy, orderType, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the customer service usage
        /// </summary>
        /// <remarks>
        /// Returns the customer usage statistics aggregated per service from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName">The service name list. (optional)</param>
        /// <param name="participantName">The participant name. (optional)</param>
        /// <param name="status">The operation status to filter by. (optional)</param>
        /// <param name="startDate">Start of the period (inclusive). (optional)</param>
        /// <param name="endDate">End of the period (inclusive). (optional)</param>
        /// <param name="metadata">Metadata key-value pairs to filter by. (optional)</param>
        /// <param name="offset">The number of items to skip for pagination. The default value is 0. (optional)</param>
        /// <param name="limit">The maximum number of items to return for pagination. The default value is 25. (optional)</param>
        /// <param name="orderBy">The field to order by. (optional)</param>
        /// <param name="orderType">Order direction: Ascending or Descending. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-service-usage/">REST API Reference for GetCustomerServiceUsage Operation</seealso>
        /// <returns>Task of ApiResponse (CustomerServiceUsageReportWrapper)</returns>
        public async Task<ApiResponse<CustomerServiceUsageReportWrapper>> GetCustomerServiceUsageWithHttpInfoAsync(List<string>? serviceName = default, string? participantName = default, OperationStatus? status = default, DateTime? startDate = default, DateTime? endDate = default, Dictionary<string, string>? metadata = default, int? offset = default, int? limit = default, string? orderBy = default, OperationOrderType? orderType = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (serviceName != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("multi", "ServiceName", serviceName));
            }
            if (participantName != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "ParticipantName", participantName));
            }
            if (status != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Status", status));
            }
            if (startDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "StartDate", startDate));
            }
            if (endDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "EndDate", endDate));
            }
            if (metadata != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Metadata", metadata));
            }
            if (offset != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "offset", offset));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (orderBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "OrderBy", orderBy));
            }
            if (orderType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "OrderType", orderType));
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

            var localVarResponse = await AsynchronousClient.GetAsync<CustomerServiceUsageReportWrapper>("/api/2.0/portal/payment/customer/usage", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetCustomerServiceUsage", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the status of the customer service usage report generation
        /// </summary>
        /// <remarks>
        /// Returns the status of generating a customer service usage report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-service-usage-report/">REST API Reference for GetCustomerServiceUsageReport Operation</seealso>
        /// <returns>DocumentBuilderTaskWrapper</returns>
        public DocumentBuilderTaskWrapper GetCustomerServiceUsageReport()
        {
            var localVarResponse = GetCustomerServiceUsageReportWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the status of the customer service usage report generation
        /// </summary>
        /// <remarks>
        /// Returns the status of generating a customer service usage report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-service-usage-report/">REST API Reference for GetCustomerServiceUsageReport Operation</seealso>
        /// <returns>ApiResponse of DocumentBuilderTaskWrapper</returns>
        public ApiResponse<DocumentBuilderTaskWrapper> GetCustomerServiceUsageReportWithHttpInfo()
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
            var localVarResponse = Client.Get<DocumentBuilderTaskWrapper>("/api/2.0/portal/payment/customer/usage/report", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetCustomerServiceUsageReport", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the status of the customer service usage report generation
        /// </summary>
        /// <remarks>
        /// Returns the status of generating a customer service usage report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-service-usage-report/">REST API Reference for GetCustomerServiceUsageReport Operation</seealso>
        /// <returns>Task of DocumentBuilderTaskWrapper</returns>
        public async Task<DocumentBuilderTaskWrapper> GetCustomerServiceUsageReportAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetCustomerServiceUsageReportWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the status of the customer service usage report generation
        /// </summary>
        /// <remarks>
        /// Returns the status of generating a customer service usage report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-service-usage-report/">REST API Reference for GetCustomerServiceUsageReport Operation</seealso>
        /// <returns>Task of ApiResponse (DocumentBuilderTaskWrapper)</returns>
        public async Task<ApiResponse<DocumentBuilderTaskWrapper>> GetCustomerServiceUsageReportWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<DocumentBuilderTaskWrapper>("/api/2.0/portal/payment/customer/usage/report", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetCustomerServiceUsageReport", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the payment account
        /// </summary>
        /// <remarks>
        /// Returns the URL to the payment account.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">The URL where the user will be redirected after payment processing. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-account/">REST API Reference for GetPaymentAccount Operation</seealso>
        /// <returns>StringWrapper</returns>
        public StringWrapper GetPaymentAccount(string? backUrl = default)
        {
            var localVarResponse = GetPaymentAccountWithHttpInfo(backUrl);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the payment account
        /// </summary>
        /// <remarks>
        /// Returns the URL to the payment account.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">The URL where the user will be redirected after payment processing. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-account/">REST API Reference for GetPaymentAccount Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        public ApiResponse<StringWrapper> GetPaymentAccountWithHttpInfo(string? backUrl = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (backUrl != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "backUrl", backUrl));
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
            var localVarResponse = Client.Get<StringWrapper>("/api/2.0/portal/payment/account", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPaymentAccount", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the payment account
        /// </summary>
        /// <remarks>
        /// Returns the URL to the payment account.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">The URL where the user will be redirected after payment processing. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-account/">REST API Reference for GetPaymentAccount Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        public async Task<StringWrapper> GetPaymentAccountAsync(string? backUrl = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetPaymentAccountWithHttpInfoAsync(backUrl, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the payment account
        /// </summary>
        /// <remarks>
        /// Returns the URL to the payment account.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">The URL where the user will be redirected after payment processing. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-account/">REST API Reference for GetPaymentAccount Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        public async Task<ApiResponse<StringWrapper>> GetPaymentAccountWithHttpInfoAsync(string? backUrl = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (backUrl != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "backUrl", backUrl));
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

            var localVarResponse = await AsynchronousClient.GetAsync<StringWrapper>("/api/2.0/portal/payment/account", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPaymentAccount", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get currencies
        /// </summary>
        /// <remarks>
        /// Returns the available portal currencies.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-currencies/">REST API Reference for GetPaymentCurrencies Operation</seealso>
        /// <returns>CurrenciesArrayWrapper</returns>
        public CurrenciesArrayWrapper GetPaymentCurrencies()
        {
            var localVarResponse = GetPaymentCurrenciesWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get currencies
        /// </summary>
        /// <remarks>
        /// Returns the available portal currencies.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-currencies/">REST API Reference for GetPaymentCurrencies Operation</seealso>
        /// <returns>ApiResponse of CurrenciesArrayWrapper</returns>
        public ApiResponse<CurrenciesArrayWrapper> GetPaymentCurrenciesWithHttpInfo()
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
            var localVarResponse = Client.Get<CurrenciesArrayWrapper>("/api/2.0/portal/payment/currencies", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPaymentCurrencies", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get currencies
        /// </summary>
        /// <remarks>
        /// Returns the available portal currencies.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-currencies/">REST API Reference for GetPaymentCurrencies Operation</seealso>
        /// <returns>Task of CurrenciesArrayWrapper</returns>
        public async Task<CurrenciesArrayWrapper> GetPaymentCurrenciesAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetPaymentCurrenciesWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get currencies
        /// </summary>
        /// <remarks>
        /// Returns the available portal currencies.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-currencies/">REST API Reference for GetPaymentCurrencies Operation</seealso>
        /// <returns>Task of ApiResponse (CurrenciesArrayWrapper)</returns>
        public async Task<ApiResponse<CurrenciesArrayWrapper>> GetPaymentCurrenciesWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<CurrenciesArrayWrapper>("/api/2.0/portal/payment/currencies", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPaymentCurrencies", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get quotas
        /// </summary>
        /// <remarks>
        /// Returns the available portal quotas.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wallet">Specifies whether to return the wallet quotas only. (optional)</param>
        /// <param name="additional">Specifies whether to return additional quotas only. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-quotas/">REST API Reference for GetPaymentQuotas Operation</seealso>
        /// <returns>QuotaArrayWrapper</returns>
        public QuotaArrayWrapper GetPaymentQuotas(bool? wallet = default, bool? additional = default)
        {
            var localVarResponse = GetPaymentQuotasWithHttpInfo(wallet, additional);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get quotas
        /// </summary>
        /// <remarks>
        /// Returns the available portal quotas.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wallet">Specifies whether to return the wallet quotas only. (optional)</param>
        /// <param name="additional">Specifies whether to return additional quotas only. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-quotas/">REST API Reference for GetPaymentQuotas Operation</seealso>
        /// <returns>ApiResponse of QuotaArrayWrapper</returns>
        public ApiResponse<QuotaArrayWrapper> GetPaymentQuotasWithHttpInfo(bool? wallet = default, bool? additional = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (wallet != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "wallet", wallet));
            }
            if (additional != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "additional", additional));
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
            var localVarResponse = Client.Get<QuotaArrayWrapper>("/api/2.0/portal/payment/quotas", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPaymentQuotas", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get quotas
        /// </summary>
        /// <remarks>
        /// Returns the available portal quotas.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wallet">Specifies whether to return the wallet quotas only. (optional)</param>
        /// <param name="additional">Specifies whether to return additional quotas only. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-quotas/">REST API Reference for GetPaymentQuotas Operation</seealso>
        /// <returns>Task of QuotaArrayWrapper</returns>
        public async Task<QuotaArrayWrapper> GetPaymentQuotasAsync(bool? wallet = default, bool? additional = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetPaymentQuotasWithHttpInfoAsync(wallet, additional, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get quotas
        /// </summary>
        /// <remarks>
        /// Returns the available portal quotas.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wallet">Specifies whether to return the wallet quotas only. (optional)</param>
        /// <param name="additional">Specifies whether to return additional quotas only. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-quotas/">REST API Reference for GetPaymentQuotas Operation</seealso>
        /// <returns>Task of ApiResponse (QuotaArrayWrapper)</returns>
        public async Task<ApiResponse<QuotaArrayWrapper>> GetPaymentQuotasWithHttpInfoAsync(bool? wallet = default, bool? additional = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (wallet != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "wallet", wallet));
            }
            if (additional != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "additional", additional));
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

            var localVarResponse = await AsynchronousClient.GetAsync<QuotaArrayWrapper>("/api/2.0/portal/payment/quotas", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPaymentQuotas", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the payment page URL
        /// </summary>
        /// <remarks>
        /// Returns the URL to the payment page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentUrlRequestDto">The request parameters for the payment URL configuration with quantity information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-url/">REST API Reference for GetPaymentUrl Operation</seealso>
        /// <returns>StringWrapper</returns>
        public StringWrapper GetPaymentUrl(PaymentUrlRequestDto? paymentUrlRequestDto = default)
        {
            var localVarResponse = GetPaymentUrlWithHttpInfo(paymentUrlRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the payment page URL
        /// </summary>
        /// <remarks>
        /// Returns the URL to the payment page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentUrlRequestDto">The request parameters for the payment URL configuration with quantity information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-url/">REST API Reference for GetPaymentUrl Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        public ApiResponse<StringWrapper> GetPaymentUrlWithHttpInfo(PaymentUrlRequestDto? paymentUrlRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (paymentUrlRequestDto != null) localVarRequestOptions.Data = paymentUrlRequestDto;

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
            var localVarResponse = Client.Put<StringWrapper>("/api/2.0/portal/payment/url", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPaymentUrl", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the payment page URL
        /// </summary>
        /// <remarks>
        /// Returns the URL to the payment page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentUrlRequestDto">The request parameters for the payment URL configuration with quantity information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-url/">REST API Reference for GetPaymentUrl Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        public async Task<StringWrapper> GetPaymentUrlAsync(PaymentUrlRequestDto? paymentUrlRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetPaymentUrlWithHttpInfoAsync(paymentUrlRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the payment page URL
        /// </summary>
        /// <remarks>
        /// Returns the URL to the payment page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentUrlRequestDto">The request parameters for the payment URL configuration with quantity information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-url/">REST API Reference for GetPaymentUrl Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        public async Task<ApiResponse<StringWrapper>> GetPaymentUrlWithHttpInfoAsync(PaymentUrlRequestDto? paymentUrlRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (paymentUrlRequestDto != null) localVarRequestOptions.Data = paymentUrlRequestDto;

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

            var localVarResponse = await AsynchronousClient.PutAsync<StringWrapper>("/api/2.0/portal/payment/url", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPaymentUrl", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get prices
        /// </summary>
        /// <remarks>
        /// Returns the available portal prices.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-prices/">REST API Reference for GetPortalPrices Operation</seealso>
        /// <returns>GetPortalPrices200Response</returns>
        public GetPortalPrices200Response GetPortalPrices()
        {
            var localVarResponse = GetPortalPricesWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get prices
        /// </summary>
        /// <remarks>
        /// Returns the available portal prices.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-prices/">REST API Reference for GetPortalPrices Operation</seealso>
        /// <returns>ApiResponse of GetPortalPrices200Response</returns>
        public ApiResponse<GetPortalPrices200Response> GetPortalPricesWithHttpInfo()
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
            var localVarResponse = Client.Get<GetPortalPrices200Response>("/api/2.0/portal/payment/prices", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPortalPrices", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get prices
        /// </summary>
        /// <remarks>
        /// Returns the available portal prices.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-prices/">REST API Reference for GetPortalPrices Operation</seealso>
        /// <returns>Task of GetPortalPrices200Response</returns>
        public async Task<GetPortalPrices200Response> GetPortalPricesAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetPortalPricesWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get prices
        /// </summary>
        /// <remarks>
        /// Returns the available portal prices.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-prices/">REST API Reference for GetPortalPrices Operation</seealso>
        /// <returns>Task of ApiResponse (GetPortalPrices200Response)</returns>
        public async Task<ApiResponse<GetPortalPrices200Response>> GetPortalPricesWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<GetPortalPrices200Response>("/api/2.0/portal/payment/prices", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPortalPrices", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get quota payment information
        /// </summary>
        /// <remarks>
        /// Returns the payment information about the current portal quota.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-quota-payment-information/">REST API Reference for GetQuotaPaymentInformation Operation</seealso>
        /// <returns>QuotaWrapper</returns>
        public QuotaWrapper GetQuotaPaymentInformation(bool? refresh = default)
        {
            var localVarResponse = GetQuotaPaymentInformationWithHttpInfo(refresh);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get quota payment information
        /// </summary>
        /// <remarks>
        /// Returns the payment information about the current portal quota.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-quota-payment-information/">REST API Reference for GetQuotaPaymentInformation Operation</seealso>
        /// <returns>ApiResponse of QuotaWrapper</returns>
        public ApiResponse<QuotaWrapper> GetQuotaPaymentInformationWithHttpInfo(bool? refresh = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (refresh != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "refresh", refresh));
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
            var localVarResponse = Client.Get<QuotaWrapper>("/api/2.0/portal/payment/quota", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetQuotaPaymentInformation", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get quota payment information
        /// </summary>
        /// <remarks>
        /// Returns the payment information about the current portal quota.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-quota-payment-information/">REST API Reference for GetQuotaPaymentInformation Operation</seealso>
        /// <returns>Task of QuotaWrapper</returns>
        public async Task<QuotaWrapper> GetQuotaPaymentInformationAsync(bool? refresh = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetQuotaPaymentInformationWithHttpInfoAsync(refresh, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get quota payment information
        /// </summary>
        /// <remarks>
        /// Returns the payment information about the current portal quota.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-quota-payment-information/">REST API Reference for GetQuotaPaymentInformation Operation</seealso>
        /// <returns>Task of ApiResponse (QuotaWrapper)</returns>
        public async Task<ApiResponse<QuotaWrapper>> GetQuotaPaymentInformationWithHttpInfoAsync(bool? refresh = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (refresh != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "refresh", refresh));
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

            var localVarResponse = await AsynchronousClient.GetAsync<QuotaWrapper>("/api/2.0/portal/payment/quota", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetQuotaPaymentInformation", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get restricted AI models
        /// </summary>
        /// <remarks>
        /// Returns the list of AI chat model IDs that are restricted (disabled) for the current tenant.  Restricted models cannot be used for AI chat conversations by any user within the portal.  Only DocSpace administrators can access this endpoint.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-restricted-ai-models/">REST API Reference for GetRestrictedAiModels Operation</seealso>
        /// <returns>RestrictedModelsResponseWrapper</returns>
        public RestrictedModelsResponseWrapper GetRestrictedAiModels()
        {
            var localVarResponse = GetRestrictedAiModelsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get restricted AI models
        /// </summary>
        /// <remarks>
        /// Returns the list of AI chat model IDs that are restricted (disabled) for the current tenant.  Restricted models cannot be used for AI chat conversations by any user within the portal.  Only DocSpace administrators can access this endpoint.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-restricted-ai-models/">REST API Reference for GetRestrictedAiModels Operation</seealso>
        /// <returns>ApiResponse of RestrictedModelsResponseWrapper</returns>
        public ApiResponse<RestrictedModelsResponseWrapper> GetRestrictedAiModelsWithHttpInfo()
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
            var localVarResponse = Client.Get<RestrictedModelsResponseWrapper>("/api/2.0/portal/payment/ai-model/restrictions", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRestrictedAiModels", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get restricted AI models
        /// </summary>
        /// <remarks>
        /// Returns the list of AI chat model IDs that are restricted (disabled) for the current tenant.  Restricted models cannot be used for AI chat conversations by any user within the portal.  Only DocSpace administrators can access this endpoint.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-restricted-ai-models/">REST API Reference for GetRestrictedAiModels Operation</seealso>
        /// <returns>Task of RestrictedModelsResponseWrapper</returns>
        public async Task<RestrictedModelsResponseWrapper> GetRestrictedAiModelsAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetRestrictedAiModelsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get restricted AI models
        /// </summary>
        /// <remarks>
        /// Returns the list of AI chat model IDs that are restricted (disabled) for the current tenant.  Restricted models cannot be used for AI chat conversations by any user within the portal.  Only DocSpace administrators can access this endpoint.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-restricted-ai-models/">REST API Reference for GetRestrictedAiModels Operation</seealso>
        /// <returns>Task of ApiResponse (RestrictedModelsResponseWrapper)</returns>
        public async Task<ApiResponse<RestrictedModelsResponseWrapper>> GetRestrictedAiModelsWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<RestrictedModelsResponseWrapper>("/api/2.0/portal/payment/ai-model/restrictions", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRestrictedAiModels", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the subscription balance information
        /// </summary>
        /// <remarks>
        /// Returns the information about the current subscription and its unused (prorated) balance.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-subscription-balance-info/">REST API Reference for GetSubscriptionBalanceInfo Operation</seealso>
        /// <returns>SubscriptionBalanceInfoWrapper</returns>
        public SubscriptionBalanceInfoWrapper GetSubscriptionBalanceInfo()
        {
            var localVarResponse = GetSubscriptionBalanceInfoWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the subscription balance information
        /// </summary>
        /// <remarks>
        /// Returns the information about the current subscription and its unused (prorated) balance.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-subscription-balance-info/">REST API Reference for GetSubscriptionBalanceInfo Operation</seealso>
        /// <returns>ApiResponse of SubscriptionBalanceInfoWrapper</returns>
        public ApiResponse<SubscriptionBalanceInfoWrapper> GetSubscriptionBalanceInfoWithHttpInfo()
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
            var localVarResponse = Client.Get<SubscriptionBalanceInfoWrapper>("/api/2.0/portal/payment/subscription/balance", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetSubscriptionBalanceInfo", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the subscription balance information
        /// </summary>
        /// <remarks>
        /// Returns the information about the current subscription and its unused (prorated) balance.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-subscription-balance-info/">REST API Reference for GetSubscriptionBalanceInfo Operation</seealso>
        /// <returns>Task of SubscriptionBalanceInfoWrapper</returns>
        public async Task<SubscriptionBalanceInfoWrapper> GetSubscriptionBalanceInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetSubscriptionBalanceInfoWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the subscription balance information
        /// </summary>
        /// <remarks>
        /// Returns the information about the current subscription and its unused (prorated) balance.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-subscription-balance-info/">REST API Reference for GetSubscriptionBalanceInfo Operation</seealso>
        /// <returns>Task of ApiResponse (SubscriptionBalanceInfoWrapper)</returns>
        public async Task<ApiResponse<SubscriptionBalanceInfoWrapper>> GetSubscriptionBalanceInfoWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<SubscriptionBalanceInfoWrapper>("/api/2.0/portal/payment/subscription/balance", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetSubscriptionBalanceInfo", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Gets the wallet service settings for the tenant.
        /// </summary>
        /// <remarks>
        /// Retrieves configuration settings related to the wallet service associated with the current tenant.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-wallet-service-settings/">REST API Reference for GetTenantWalletServiceSettings Operation</seealso>
        /// <returns>TenantWalletServiceSettingsWrapper</returns>
        public TenantWalletServiceSettingsWrapper GetTenantWalletServiceSettings()
        {
            var localVarResponse = GetTenantWalletServiceSettingsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the wallet service settings for the tenant.
        /// </summary>
        /// <remarks>
        /// Retrieves configuration settings related to the wallet service associated with the current tenant.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-wallet-service-settings/">REST API Reference for GetTenantWalletServiceSettings Operation</seealso>
        /// <returns>ApiResponse of TenantWalletServiceSettingsWrapper</returns>
        public ApiResponse<TenantWalletServiceSettingsWrapper> GetTenantWalletServiceSettingsWithHttpInfo()
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
            var localVarResponse = Client.Get<TenantWalletServiceSettingsWrapper>("/api/2.0/portal/payment/servicessettings", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetTenantWalletServiceSettings", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Gets the wallet service settings for the tenant.
        /// </summary>
        /// <remarks>
        /// Retrieves configuration settings related to the wallet service associated with the current tenant.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-wallet-service-settings/">REST API Reference for GetTenantWalletServiceSettings Operation</seealso>
        /// <returns>Task of TenantWalletServiceSettingsWrapper</returns>
        public async Task<TenantWalletServiceSettingsWrapper> GetTenantWalletServiceSettingsAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetTenantWalletServiceSettingsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the wallet service settings for the tenant.
        /// </summary>
        /// <remarks>
        /// Retrieves configuration settings related to the wallet service associated with the current tenant.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-wallet-service-settings/">REST API Reference for GetTenantWalletServiceSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantWalletServiceSettingsWrapper)</returns>
        public async Task<ApiResponse<TenantWalletServiceSettingsWrapper>> GetTenantWalletServiceSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<TenantWalletServiceSettingsWrapper>("/api/2.0/portal/payment/servicessettings", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetTenantWalletServiceSettings", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Gets the tenant wallet auto top up settings
        /// </summary>
        /// <remarks>
        /// Returns the wallet auto top up settings for the current tenant.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-wallet-settings/">REST API Reference for GetTenantWalletSettings Operation</seealso>
        /// <returns>TenantWalletSettingsWrapper</returns>
        public TenantWalletSettingsWrapper GetTenantWalletSettings()
        {
            var localVarResponse = GetTenantWalletSettingsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the tenant wallet auto top up settings
        /// </summary>
        /// <remarks>
        /// Returns the wallet auto top up settings for the current tenant.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-wallet-settings/">REST API Reference for GetTenantWalletSettings Operation</seealso>
        /// <returns>ApiResponse of TenantWalletSettingsWrapper</returns>
        public ApiResponse<TenantWalletSettingsWrapper> GetTenantWalletSettingsWithHttpInfo()
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
            var localVarResponse = Client.Get<TenantWalletSettingsWrapper>("/api/2.0/portal/payment/topupsettings", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetTenantWalletSettings", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Gets the tenant wallet auto top up settings
        /// </summary>
        /// <remarks>
        /// Returns the wallet auto top up settings for the current tenant.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-wallet-settings/">REST API Reference for GetTenantWalletSettings Operation</seealso>
        /// <returns>Task of TenantWalletSettingsWrapper</returns>
        public async Task<TenantWalletSettingsWrapper> GetTenantWalletSettingsAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetTenantWalletSettingsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the tenant wallet auto top up settings
        /// </summary>
        /// <remarks>
        /// Returns the wallet auto top up settings for the current tenant.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-wallet-settings/">REST API Reference for GetTenantWalletSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantWalletSettingsWrapper)</returns>
        public async Task<ApiResponse<TenantWalletSettingsWrapper>> GetTenantWalletSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<TenantWalletSettingsWrapper>("/api/2.0/portal/payment/topupsettings", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetTenantWalletSettings", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get wallet service
        /// </summary>
        /// <remarks>
        /// Returns the specified wallet service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="service">The wallet service type.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-wallet-service/">REST API Reference for GetWalletService Operation</seealso>
        /// <returns>WalletServiceWrapper</returns>
        public WalletServiceWrapper GetWalletService(TenantWalletService service)
        {
            var localVarResponse = GetWalletServiceWithHttpInfo(service);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get wallet service
        /// </summary>
        /// <remarks>
        /// Returns the specified wallet service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="service">The wallet service type.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-wallet-service/">REST API Reference for GetWalletService Operation</seealso>
        /// <returns>ApiResponse of WalletServiceWrapper</returns>
        public ApiResponse<WalletServiceWrapper> GetWalletServiceWithHttpInfo(TenantWalletService service)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "service", service));

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
            var localVarResponse = Client.Get<WalletServiceWrapper>("/api/2.0/portal/payment/walletservice", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetWalletService", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get wallet service
        /// </summary>
        /// <remarks>
        /// Returns the specified wallet service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="service">The wallet service type.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-wallet-service/">REST API Reference for GetWalletService Operation</seealso>
        /// <returns>Task of WalletServiceWrapper</returns>
        public async Task<WalletServiceWrapper> GetWalletServiceAsync(TenantWalletService service, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetWalletServiceWithHttpInfoAsync(service, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get wallet service
        /// </summary>
        /// <remarks>
        /// Returns the specified wallet service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="service">The wallet service type.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-wallet-service/">REST API Reference for GetWalletService Operation</seealso>
        /// <returns>Task of ApiResponse (WalletServiceWrapper)</returns>
        public async Task<ApiResponse<WalletServiceWrapper>> GetWalletServiceWithHttpInfoAsync(TenantWalletService service, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "service", service));

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

            var localVarResponse = await AsynchronousClient.GetAsync<WalletServiceWrapper>("/api/2.0/portal/payment/walletservice", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetWalletService", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get wallet services
        /// </summary>
        /// <remarks>
        /// Returns the available wallet services.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-wallet-services/">REST API Reference for GetWalletServices Operation</seealso>
        /// <returns>WalletServiceArrayWrapper</returns>
        public WalletServiceArrayWrapper GetWalletServices()
        {
            var localVarResponse = GetWalletServicesWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get wallet services
        /// </summary>
        /// <remarks>
        /// Returns the available wallet services.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-wallet-services/">REST API Reference for GetWalletServices Operation</seealso>
        /// <returns>ApiResponse of WalletServiceArrayWrapper</returns>
        public ApiResponse<WalletServiceArrayWrapper> GetWalletServicesWithHttpInfo()
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
            var localVarResponse = Client.Get<WalletServiceArrayWrapper>("/api/2.0/portal/payment/walletservices", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetWalletServices", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get wallet services
        /// </summary>
        /// <remarks>
        /// Returns the available wallet services.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-wallet-services/">REST API Reference for GetWalletServices Operation</seealso>
        /// <returns>Task of WalletServiceArrayWrapper</returns>
        public async Task<WalletServiceArrayWrapper> GetWalletServicesAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetWalletServicesWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get wallet services
        /// </summary>
        /// <remarks>
        /// Returns the available wallet services.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-wallet-services/">REST API Reference for GetWalletServices Operation</seealso>
        /// <returns>Task of ApiResponse (WalletServiceArrayWrapper)</returns>
        public async Task<ApiResponse<WalletServiceArrayWrapper>> GetWalletServicesWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<WalletServiceArrayWrapper>("/api/2.0/portal/payment/walletservices", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetWalletServices", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Move the subscription balance to the wallet and purchase admins
        /// </summary>
        /// <remarks>
        /// Cancels the current subscription, moves its unused balance to the wallet, and purchases the requested number of  admins from the wallet. If the wallet balance is not enough, it is topped up for the missing amount first  (with several attempts, as the balance may be consumed concurrently).
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quantityRequestDto">The request parameters for specifying payment quantity. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-subscription-to-wallet/">REST API Reference for MoveSubscriptionToWallet Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper MoveSubscriptionToWallet(QuantityRequestDto? quantityRequestDto = default)
        {
            var localVarResponse = MoveSubscriptionToWalletWithHttpInfo(quantityRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Move the subscription balance to the wallet and purchase admins
        /// </summary>
        /// <remarks>
        /// Cancels the current subscription, moves its unused balance to the wallet, and purchases the requested number of  admins from the wallet. If the wallet balance is not enough, it is topped up for the missing amount first  (with several attempts, as the balance may be consumed concurrently).
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quantityRequestDto">The request parameters for specifying payment quantity. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-subscription-to-wallet/">REST API Reference for MoveSubscriptionToWallet Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> MoveSubscriptionToWalletWithHttpInfo(QuantityRequestDto? quantityRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (quantityRequestDto != null) localVarRequestOptions.Data = quantityRequestDto;

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
            var localVarResponse = Client.Post<BooleanWrapper>("/api/2.0/portal/payment/subscription/movetowallet", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("MoveSubscriptionToWallet", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Move the subscription balance to the wallet and purchase admins
        /// </summary>
        /// <remarks>
        /// Cancels the current subscription, moves its unused balance to the wallet, and purchases the requested number of  admins from the wallet. If the wallet balance is not enough, it is topped up for the missing amount first  (with several attempts, as the balance may be consumed concurrently).
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quantityRequestDto">The request parameters for specifying payment quantity. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-subscription-to-wallet/">REST API Reference for MoveSubscriptionToWallet Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async Task<BooleanWrapper> MoveSubscriptionToWalletAsync(QuantityRequestDto? quantityRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await MoveSubscriptionToWalletWithHttpInfoAsync(quantityRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Move the subscription balance to the wallet and purchase admins
        /// </summary>
        /// <remarks>
        /// Cancels the current subscription, moves its unused balance to the wallet, and purchases the requested number of  admins from the wallet. If the wallet balance is not enough, it is topped up for the missing amount first  (with several attempts, as the balance may be consumed concurrently).
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quantityRequestDto">The request parameters for specifying payment quantity. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-subscription-to-wallet/">REST API Reference for MoveSubscriptionToWallet Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async Task<ApiResponse<BooleanWrapper>> MoveSubscriptionToWalletWithHttpInfoAsync(QuantityRequestDto? quantityRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (quantityRequestDto != null) localVarRequestOptions.Data = quantityRequestDto;

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

            var localVarResponse = await AsynchronousClient.PostAsync<BooleanWrapper>("/api/2.0/portal/payment/subscription/movetowallet", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("MoveSubscriptionToWallet", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send a payment request
        /// </summary>
        /// <remarks>
        /// Sends a request for the portal payment.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesRequestsDto">The request parameters for handling sales and payment inquiries in the portal. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-payment-request/">REST API Reference for SendPaymentRequest Operation</seealso>
        /// <returns></returns>
        public void SendPaymentRequest(SalesRequestsDto? salesRequestsDto = default)
        {
            SendPaymentRequestWithHttpInfo(salesRequestsDto);
        }

        /// <summary>
        /// Send a payment request
        /// </summary>
        /// <remarks>
        /// Sends a request for the portal payment.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesRequestsDto">The request parameters for handling sales and payment inquiries in the portal. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-payment-request/">REST API Reference for SendPaymentRequest Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> SendPaymentRequestWithHttpInfo(SalesRequestsDto? salesRequestsDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (salesRequestsDto != null) localVarRequestOptions.Data = salesRequestsDto;

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
            var localVarResponse = Client.Post<Object>("/api/2.0/portal/payment/request", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SendPaymentRequest", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send a payment request
        /// </summary>
        /// <remarks>
        /// Sends a request for the portal payment.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesRequestsDto">The request parameters for handling sales and payment inquiries in the portal. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-payment-request/">REST API Reference for SendPaymentRequest Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task SendPaymentRequestAsync(SalesRequestsDto? salesRequestsDto = default, CancellationToken cancellationToken = default)
        {
            await SendPaymentRequestWithHttpInfoAsync(salesRequestsDto, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Send a payment request
        /// </summary>
        /// <remarks>
        /// Sends a request for the portal payment.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesRequestsDto">The request parameters for handling sales and payment inquiries in the portal. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-payment-request/">REST API Reference for SendPaymentRequest Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> SendPaymentRequestWithHttpInfoAsync(SalesRequestsDto? salesRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (salesRequestsDto != null) localVarRequestOptions.Data = salesRequestsDto;

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

            var localVarResponse = await AsynchronousClient.PostAsync<Object>("/api/2.0/portal/payment/request", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SendPaymentRequest", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set restricted AI models
        /// </summary>
        /// <remarks>
        /// Overwrites the entire set of restricted AI model IDs for the current tenant.  The request body must contain the complete desired set — to add a restriction, include the new model alongside existing ones;  to remove one, omit it. An empty set lifts all restrictions. Only the portal payer can perform this action.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setRestrictedAiModelsRequestDto">The request parameters for setting restricted AI models. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-restricted-ai-models/">REST API Reference for SetRestrictedAiModels Operation</seealso>
        /// <returns>RestrictedModelsResponseWrapper</returns>
        public RestrictedModelsResponseWrapper SetRestrictedAiModels(SetRestrictedAiModelsRequestDto? setRestrictedAiModelsRequestDto = default)
        {
            var localVarResponse = SetRestrictedAiModelsWithHttpInfo(setRestrictedAiModelsRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set restricted AI models
        /// </summary>
        /// <remarks>
        /// Overwrites the entire set of restricted AI model IDs for the current tenant.  The request body must contain the complete desired set — to add a restriction, include the new model alongside existing ones;  to remove one, omit it. An empty set lifts all restrictions. Only the portal payer can perform this action.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setRestrictedAiModelsRequestDto">The request parameters for setting restricted AI models. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-restricted-ai-models/">REST API Reference for SetRestrictedAiModels Operation</seealso>
        /// <returns>ApiResponse of RestrictedModelsResponseWrapper</returns>
        public ApiResponse<RestrictedModelsResponseWrapper> SetRestrictedAiModelsWithHttpInfo(SetRestrictedAiModelsRequestDto? setRestrictedAiModelsRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (setRestrictedAiModelsRequestDto != null) localVarRequestOptions.Data = setRestrictedAiModelsRequestDto;

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
            var localVarResponse = Client.Put<RestrictedModelsResponseWrapper>("/api/2.0/portal/payment/ai-model/restrictions", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetRestrictedAiModels", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set restricted AI models
        /// </summary>
        /// <remarks>
        /// Overwrites the entire set of restricted AI model IDs for the current tenant.  The request body must contain the complete desired set — to add a restriction, include the new model alongside existing ones;  to remove one, omit it. An empty set lifts all restrictions. Only the portal payer can perform this action.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setRestrictedAiModelsRequestDto">The request parameters for setting restricted AI models. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-restricted-ai-models/">REST API Reference for SetRestrictedAiModels Operation</seealso>
        /// <returns>Task of RestrictedModelsResponseWrapper</returns>
        public async Task<RestrictedModelsResponseWrapper> SetRestrictedAiModelsAsync(SetRestrictedAiModelsRequestDto? setRestrictedAiModelsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetRestrictedAiModelsWithHttpInfoAsync(setRestrictedAiModelsRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set restricted AI models
        /// </summary>
        /// <remarks>
        /// Overwrites the entire set of restricted AI model IDs for the current tenant.  The request body must contain the complete desired set — to add a restriction, include the new model alongside existing ones;  to remove one, omit it. An empty set lifts all restrictions. Only the portal payer can perform this action.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setRestrictedAiModelsRequestDto">The request parameters for setting restricted AI models. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-restricted-ai-models/">REST API Reference for SetRestrictedAiModels Operation</seealso>
        /// <returns>Task of ApiResponse (RestrictedModelsResponseWrapper)</returns>
        public async Task<ApiResponse<RestrictedModelsResponseWrapper>> SetRestrictedAiModelsWithHttpInfoAsync(SetRestrictedAiModelsRequestDto? setRestrictedAiModelsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (setRestrictedAiModelsRequestDto != null) localVarRequestOptions.Data = setRestrictedAiModelsRequestDto;

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

            var localVarResponse = await AsynchronousClient.PutAsync<RestrictedModelsResponseWrapper>("/api/2.0/portal/payment/ai-model/restrictions", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetRestrictedAiModels", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set the wallet auto top up settings
        /// </summary>
        /// <remarks>
        /// Updates the wallet auto top up settings for the current tenant.  Requires the tariff service to be configured and the user to be authorized as a payer.  Returns null if the tariff service is not configured or customer information/balance cannot be retrieved.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantWalletSettingsWrapper">The wrapper for the tenant wallet settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tenant-wallet-settings/">REST API Reference for SetTenantWalletSettings Operation</seealso>
        /// <returns>TenantWalletSettingsWrapper</returns>
        public TenantWalletSettingsWrapper SetTenantWalletSettings(TenantWalletSettingsWrapper? tenantWalletSettingsWrapper = default)
        {
            var localVarResponse = SetTenantWalletSettingsWithHttpInfo(tenantWalletSettingsWrapper);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set the wallet auto top up settings
        /// </summary>
        /// <remarks>
        /// Updates the wallet auto top up settings for the current tenant.  Requires the tariff service to be configured and the user to be authorized as a payer.  Returns null if the tariff service is not configured or customer information/balance cannot be retrieved.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantWalletSettingsWrapper">The wrapper for the tenant wallet settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tenant-wallet-settings/">REST API Reference for SetTenantWalletSettings Operation</seealso>
        /// <returns>ApiResponse of TenantWalletSettingsWrapper</returns>
        public ApiResponse<TenantWalletSettingsWrapper> SetTenantWalletSettingsWithHttpInfo(TenantWalletSettingsWrapper? tenantWalletSettingsWrapper = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (tenantWalletSettingsWrapper != null) localVarRequestOptions.Data = tenantWalletSettingsWrapper;

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
            var localVarResponse = Client.Post<TenantWalletSettingsWrapper>("/api/2.0/portal/payment/topupsettings", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetTenantWalletSettings", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set the wallet auto top up settings
        /// </summary>
        /// <remarks>
        /// Updates the wallet auto top up settings for the current tenant.  Requires the tariff service to be configured and the user to be authorized as a payer.  Returns null if the tariff service is not configured or customer information/balance cannot be retrieved.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantWalletSettingsWrapper">The wrapper for the tenant wallet settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tenant-wallet-settings/">REST API Reference for SetTenantWalletSettings Operation</seealso>
        /// <returns>Task of TenantWalletSettingsWrapper</returns>
        public async Task<TenantWalletSettingsWrapper> SetTenantWalletSettingsAsync(TenantWalletSettingsWrapper? tenantWalletSettingsWrapper = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetTenantWalletSettingsWithHttpInfoAsync(tenantWalletSettingsWrapper, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set the wallet auto top up settings
        /// </summary>
        /// <remarks>
        /// Updates the wallet auto top up settings for the current tenant.  Requires the tariff service to be configured and the user to be authorized as a payer.  Returns null if the tariff service is not configured or customer information/balance cannot be retrieved.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantWalletSettingsWrapper">The wrapper for the tenant wallet settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tenant-wallet-settings/">REST API Reference for SetTenantWalletSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantWalletSettingsWrapper)</returns>
        public async Task<ApiResponse<TenantWalletSettingsWrapper>> SetTenantWalletSettingsWithHttpInfoAsync(TenantWalletSettingsWrapper? tenantWalletSettingsWrapper = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (tenantWalletSettingsWrapper != null) localVarRequestOptions.Data = tenantWalletSettingsWrapper;

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

            var localVarResponse = await AsynchronousClient.PostAsync<TenantWalletSettingsWrapper>("/api/2.0/portal/payment/topupsettings", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetTenantWalletSettings", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Terminate the customer monthly usage report generation
        /// </summary>
        /// <remarks>
        /// Terminates generating a customer monthly usage report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-monthly-usage-report/">REST API Reference for TerminateCustomerMonthlyUsageReport Operation</seealso>
        /// <returns></returns>
        public void TerminateCustomerMonthlyUsageReport()
        {
            TerminateCustomerMonthlyUsageReportWithHttpInfo();
        }

        /// <summary>
        /// Terminate the customer monthly usage report generation
        /// </summary>
        /// <remarks>
        /// Terminates generating a customer monthly usage report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-monthly-usage-report/">REST API Reference for TerminateCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> TerminateCustomerMonthlyUsageReportWithHttpInfo()
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
            var localVarResponse = Client.Delete<Object>("/api/2.0/portal/payment/customer/usage/monthly/report", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("TerminateCustomerMonthlyUsageReport", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Terminate the customer monthly usage report generation
        /// </summary>
        /// <remarks>
        /// Terminates generating a customer monthly usage report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-monthly-usage-report/">REST API Reference for TerminateCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task TerminateCustomerMonthlyUsageReportAsync(CancellationToken cancellationToken = default)
        {
            await TerminateCustomerMonthlyUsageReportWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Terminate the customer monthly usage report generation
        /// </summary>
        /// <remarks>
        /// Terminates generating a customer monthly usage report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-monthly-usage-report/">REST API Reference for TerminateCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> TerminateCustomerMonthlyUsageReportWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.DeleteAsync<Object>("/api/2.0/portal/payment/customer/usage/monthly/report", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("TerminateCustomerMonthlyUsageReport", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Terminate the customer operations report generation
        /// </summary>
        /// <remarks>
        /// Terminates generating a customer operations report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-operations-report/">REST API Reference for TerminateCustomerOperationsReport Operation</seealso>
        /// <returns></returns>
        public void TerminateCustomerOperationsReport()
        {
            TerminateCustomerOperationsReportWithHttpInfo();
        }

        /// <summary>
        /// Terminate the customer operations report generation
        /// </summary>
        /// <remarks>
        /// Terminates generating a customer operations report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-operations-report/">REST API Reference for TerminateCustomerOperationsReport Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> TerminateCustomerOperationsReportWithHttpInfo()
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
            var localVarResponse = Client.Delete<Object>("/api/2.0/portal/payment/customer/operationsreport", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("TerminateCustomerOperationsReport", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Terminate the customer operations report generation
        /// </summary>
        /// <remarks>
        /// Terminates generating a customer operations report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-operations-report/">REST API Reference for TerminateCustomerOperationsReport Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task TerminateCustomerOperationsReportAsync(CancellationToken cancellationToken = default)
        {
            await TerminateCustomerOperationsReportWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Terminate the customer operations report generation
        /// </summary>
        /// <remarks>
        /// Terminates generating a customer operations report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-operations-report/">REST API Reference for TerminateCustomerOperationsReport Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> TerminateCustomerOperationsReportWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.DeleteAsync<Object>("/api/2.0/portal/payment/customer/operationsreport", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("TerminateCustomerOperationsReport", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Terminate the customer service usage report generation
        /// </summary>
        /// <remarks>
        /// Terminates generating a customer service usage report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-service-usage-report/">REST API Reference for TerminateCustomerServiceUsageReport Operation</seealso>
        /// <returns></returns>
        public void TerminateCustomerServiceUsageReport()
        {
            TerminateCustomerServiceUsageReportWithHttpInfo();
        }

        /// <summary>
        /// Terminate the customer service usage report generation
        /// </summary>
        /// <remarks>
        /// Terminates generating a customer service usage report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-service-usage-report/">REST API Reference for TerminateCustomerServiceUsageReport Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> TerminateCustomerServiceUsageReportWithHttpInfo()
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
            var localVarResponse = Client.Delete<Object>("/api/2.0/portal/payment/customer/usage/report", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("TerminateCustomerServiceUsageReport", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Terminate the customer service usage report generation
        /// </summary>
        /// <remarks>
        /// Terminates generating a customer service usage report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-service-usage-report/">REST API Reference for TerminateCustomerServiceUsageReport Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task TerminateCustomerServiceUsageReportAsync(CancellationToken cancellationToken = default)
        {
            await TerminateCustomerServiceUsageReportWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Terminate the customer service usage report generation
        /// </summary>
        /// <remarks>
        /// Terminates generating a customer service usage report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-service-usage-report/">REST API Reference for TerminateCustomerServiceUsageReport Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> TerminateCustomerServiceUsageReportWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.DeleteAsync<Object>("/api/2.0/portal/payment/customer/usage/report", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("TerminateCustomerServiceUsageReport", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Put money on deposit
        /// </summary>
        /// <remarks>
        /// Returns the result of putting money on deposit.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topUpDepositRequestDto">The request parameters for putting money on deposit. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/top-up-deposit/">REST API Reference for TopUpDeposit Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper TopUpDeposit(TopUpDepositRequestDto? topUpDepositRequestDto = default)
        {
            var localVarResponse = TopUpDepositWithHttpInfo(topUpDepositRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Put money on deposit
        /// </summary>
        /// <remarks>
        /// Returns the result of putting money on deposit.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topUpDepositRequestDto">The request parameters for putting money on deposit. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/top-up-deposit/">REST API Reference for TopUpDeposit Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> TopUpDepositWithHttpInfo(TopUpDepositRequestDto? topUpDepositRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (topUpDepositRequestDto != null) localVarRequestOptions.Data = topUpDepositRequestDto;

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
            var localVarResponse = Client.Post<BooleanWrapper>("/api/2.0/portal/payment/deposit", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("TopUpDeposit", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Put money on deposit
        /// </summary>
        /// <remarks>
        /// Returns the result of putting money on deposit.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topUpDepositRequestDto">The request parameters for putting money on deposit. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/top-up-deposit/">REST API Reference for TopUpDeposit Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async Task<BooleanWrapper> TopUpDepositAsync(TopUpDepositRequestDto? topUpDepositRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await TopUpDepositWithHttpInfoAsync(topUpDepositRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Put money on deposit
        /// </summary>
        /// <remarks>
        /// Returns the result of putting money on deposit.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topUpDepositRequestDto">The request parameters for putting money on deposit. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/top-up-deposit/">REST API Reference for TopUpDeposit Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async Task<ApiResponse<BooleanWrapper>> TopUpDepositWithHttpInfoAsync(TopUpDepositRequestDto? topUpDepositRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (topUpDepositRequestDto != null) localVarRequestOptions.Data = topUpDepositRequestDto;

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

            var localVarResponse = await AsynchronousClient.PostAsync<BooleanWrapper>("/api/2.0/portal/payment/deposit", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("TopUpDeposit", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update the payment quantity
        /// </summary>
        /// <remarks>
        /// Updates the payment quantity with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quantityRequestDto">The request parameters for specifying payment quantity. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-payment/">REST API Reference for UpdatePayment Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper UpdatePayment(QuantityRequestDto? quantityRequestDto = default)
        {
            var localVarResponse = UpdatePaymentWithHttpInfo(quantityRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update the payment quantity
        /// </summary>
        /// <remarks>
        /// Updates the payment quantity with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quantityRequestDto">The request parameters for specifying payment quantity. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-payment/">REST API Reference for UpdatePayment Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> UpdatePaymentWithHttpInfo(QuantityRequestDto? quantityRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (quantityRequestDto != null) localVarRequestOptions.Data = quantityRequestDto;

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
            var localVarResponse = Client.Put<BooleanWrapper>("/api/2.0/portal/payment/update", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdatePayment", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update the payment quantity
        /// </summary>
        /// <remarks>
        /// Updates the payment quantity with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quantityRequestDto">The request parameters for specifying payment quantity. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-payment/">REST API Reference for UpdatePayment Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async Task<BooleanWrapper> UpdatePaymentAsync(QuantityRequestDto? quantityRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UpdatePaymentWithHttpInfoAsync(quantityRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update the payment quantity
        /// </summary>
        /// <remarks>
        /// Updates the payment quantity with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quantityRequestDto">The request parameters for specifying payment quantity. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-payment/">REST API Reference for UpdatePayment Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async Task<ApiResponse<BooleanWrapper>> UpdatePaymentWithHttpInfoAsync(QuantityRequestDto? quantityRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (quantityRequestDto != null) localVarRequestOptions.Data = quantityRequestDto;

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

            var localVarResponse = await AsynchronousClient.PutAsync<BooleanWrapper>("/api/2.0/portal/payment/update", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdatePayment", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update the wallet payment quantity
        /// </summary>
        /// <remarks>
        /// Updates the wallet payment quantity with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The request parameters for specifying wallet payment quantity. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-wallet-payment/">REST API Reference for UpdateWalletPayment Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper UpdateWalletPayment(WalletQuantityRequestDto? walletQuantityRequestDto = default)
        {
            var localVarResponse = UpdateWalletPaymentWithHttpInfo(walletQuantityRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update the wallet payment quantity
        /// </summary>
        /// <remarks>
        /// Updates the wallet payment quantity with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The request parameters for specifying wallet payment quantity. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-wallet-payment/">REST API Reference for UpdateWalletPayment Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> UpdateWalletPaymentWithHttpInfo(WalletQuantityRequestDto? walletQuantityRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (walletQuantityRequestDto != null) localVarRequestOptions.Data = walletQuantityRequestDto;

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
            var localVarResponse = Client.Put<BooleanWrapper>("/api/2.0/portal/payment/updatewallet", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateWalletPayment", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update the wallet payment quantity
        /// </summary>
        /// <remarks>
        /// Updates the wallet payment quantity with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The request parameters for specifying wallet payment quantity. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-wallet-payment/">REST API Reference for UpdateWalletPayment Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async Task<BooleanWrapper> UpdateWalletPaymentAsync(WalletQuantityRequestDto? walletQuantityRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UpdateWalletPaymentWithHttpInfoAsync(walletQuantityRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update the wallet payment quantity
        /// </summary>
        /// <remarks>
        /// Updates the wallet payment quantity with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The request parameters for specifying wallet payment quantity. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-wallet-payment/">REST API Reference for UpdateWalletPayment Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async Task<ApiResponse<BooleanWrapper>> UpdateWalletPaymentWithHttpInfoAsync(WalletQuantityRequestDto? walletQuantityRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (walletQuantityRequestDto != null) localVarRequestOptions.Data = walletQuantityRequestDto;

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

            var localVarResponse = await AsynchronousClient.PutAsync<BooleanWrapper>("/api/2.0/portal/payment/updatewallet", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateWalletPayment", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
