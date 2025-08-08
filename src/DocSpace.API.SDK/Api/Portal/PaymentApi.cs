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
namespace DocSpace.API.SDK.Api.Portal
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPaymentApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Calculate amount of the wallet payment
        /// </summary>
        /// <remarks>
        /// Calculate amount of the wallet payment with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The request parameters for the wallet payment quantity specifications. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/calculate-wallet-payment/">REST API Reference for CalculateWalletPayment Operation</seealso>
        /// <returns>PaymentCalculationWrapper</returns>
        PaymentCalculationWrapper CalculateWalletPayment(WalletQuantityRequestDto? walletQuantityRequestDto = default);

        /// <summary>
        /// Calculate amount of the wallet payment
        /// </summary>
        /// <remarks>
        /// Calculate amount of the wallet payment with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The request parameters for the wallet payment quantity specifications. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/calculate-wallet-payment/">REST API Reference for CalculateWalletPayment Operation</seealso>
        /// <returns>ApiResponse of PaymentCalculationWrapper</returns>
        ApiResponse<PaymentCalculationWrapper> CalculateWalletPaymentWithHttpInfo(WalletQuantityRequestDto? walletQuantityRequestDto = default);
        /// <summary>
        /// Generate the customer operations report
        /// </summary>
        /// <remarks>
        /// Generates the customer operations report as csv file and save in Documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerOperationsReportRequestDto">Parameters of the request for generating the report on client operations (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-operations-report/">REST API Reference for CreateCustomerOperationsReport Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper CreateCustomerOperationsReport(CustomerOperationsReportRequestDto? customerOperationsReportRequestDto = default);

        /// <summary>
        /// Generate the customer operations report
        /// </summary>
        /// <remarks>
        /// Generates the customer operations report as csv file and save in Documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerOperationsReportRequestDto">Parameters of the request for generating the report on client operations (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-operations-report/">REST API Reference for CreateCustomerOperationsReport Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> CreateCustomerOperationsReportWithHttpInfo(CustomerOperationsReportRequestDto? customerOperationsReportRequestDto = default);
        /// <summary>
        /// Get the checkout setup page URL
        /// </summary>
        /// <remarks>
        /// Returns the URL to the checkout setup page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">Back URL (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-checkout-setup-url/">REST API Reference for GetCheckoutSetupUrl Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper GetCheckoutSetupUrl(string? backUrl = default);

        /// <summary>
        /// Get the checkout setup page URL
        /// </summary>
        /// <remarks>
        /// Returns the URL to the checkout setup page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">Back URL (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-checkout-setup-url/">REST API Reference for GetCheckoutSetupUrl Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> GetCheckoutSetupUrlWithHttpInfo(string? backUrl = default);
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
        /// Get the customer info
        /// </summary>
        /// <remarks>
        /// Returns the customer info.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-info/">REST API Reference for GetCustomerInfo Operation</seealso>
        /// <returns>CustomerInfoWrapper</returns>
        CustomerInfoWrapper GetCustomerInfo(bool? refresh = default);

        /// <summary>
        /// Get the customer info
        /// </summary>
        /// <remarks>
        /// Returns the customer info.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-info/">REST API Reference for GetCustomerInfo Operation</seealso>
        /// <returns>ApiResponse of CustomerInfoWrapper</returns>
        ApiResponse<CustomerInfoWrapper> GetCustomerInfoWithHttpInfo(bool? refresh = default);
        /// <summary>
        /// Get the customer operations
        /// </summary>
        /// <remarks>
        /// Returns the report of customer operations from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Start date (optional)</param>
        /// <param name="endDate">End date (optional)</param>
        /// <param name="credit">Include credit operations (true by default) (optional)</param>
        /// <param name="withdrawal">Include withdrawal operations (true by default) (optional)</param>
        /// <param name="offset">Offset (0 by default) (optional)</param>
        /// <param name="limit">Limit (25 by default) (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-operations/">REST API Reference for GetCustomerOperations Operation</seealso>
        /// <returns>ReportWrapper</returns>
        ReportWrapper GetCustomerOperations(DateTime? startDate = default, DateTime? endDate = default, bool? credit = default, bool? withdrawal = default, int? offset = default, int? limit = default);

        /// <summary>
        /// Get the customer operations
        /// </summary>
        /// <remarks>
        /// Returns the report of customer operations from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Start date (optional)</param>
        /// <param name="endDate">End date (optional)</param>
        /// <param name="credit">Include credit operations (true by default) (optional)</param>
        /// <param name="withdrawal">Include withdrawal operations (true by default) (optional)</param>
        /// <param name="offset">Offset (0 by default) (optional)</param>
        /// <param name="limit">Limit (25 by default) (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-operations/">REST API Reference for GetCustomerOperations Operation</seealso>
        /// <returns>ApiResponse of ReportWrapper</returns>
        ApiResponse<ReportWrapper> GetCustomerOperationsWithHttpInfo(DateTime? startDate = default, DateTime? endDate = default, bool? credit = default, bool? withdrawal = default, int? offset = default, int? limit = default);
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
        /// <param name="wallet">Get wallet quotas only (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-quotas/">REST API Reference for GetPaymentQuotas Operation</seealso>
        /// <returns>QuotaArrayWrapper</returns>
        QuotaArrayWrapper GetPaymentQuotas(bool? wallet = default);

        /// <summary>
        /// Get quotas
        /// </summary>
        /// <remarks>
        /// Returns the available portal quotas.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wallet">Get wallet quotas only (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-quotas/">REST API Reference for GetPaymentQuotas Operation</seealso>
        /// <returns>ApiResponse of QuotaArrayWrapper</returns>
        ApiResponse<QuotaArrayWrapper> GetPaymentQuotasWithHttpInfo(bool? wallet = default);
        /// <summary>
        /// Get the payment page URL
        /// </summary>
        /// <remarks>
        /// Returns the URL to the payment page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentUrlRequestsDto">The request parameters for the payment URL configuration with quantity information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-url/">REST API Reference for GetPaymentUrl Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper GetPaymentUrl(PaymentUrlRequestsDto? paymentUrlRequestsDto = default);

        /// <summary>
        /// Get the payment page URL
        /// </summary>
        /// <remarks>
        /// Returns the URL to the payment page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentUrlRequestsDto">The request parameters for the payment URL configuration with quantity information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-url/">REST API Reference for GetPaymentUrl Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> GetPaymentUrlWithHttpInfo(PaymentUrlRequestsDto? paymentUrlRequestsDto = default);
        /// <summary>
        /// Get prices
        /// </summary>
        /// <remarks>
        /// Returns the available portal prices.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-prices/">REST API Reference for GetPortalPrices Operation</seealso>
        /// <returns>ObjectWrapper</returns>
        ObjectWrapper GetPortalPrices();

        /// <summary>
        /// Get prices
        /// </summary>
        /// <remarks>
        /// Returns the available portal prices.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-prices/">REST API Reference for GetPortalPrices Operation</seealso>
        /// <returns>ApiResponse of ObjectWrapper</returns>
        ApiResponse<ObjectWrapper> GetPortalPricesWithHttpInfo();
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
        /// Get wallet auto top up settings
        /// </summary>
        /// <remarks>
        /// Returns the wallet auto top up settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-wallet-settings/">REST API Reference for GetTenantWalletSettings Operation</seealso>
        /// <returns>TenantWalletSettingsWrapper</returns>
        TenantWalletSettingsWrapper GetTenantWalletSettings();

        /// <summary>
        /// Get wallet auto top up settings
        /// </summary>
        /// <remarks>
        /// Returns the wallet auto top up settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-wallet-settings/">REST API Reference for GetTenantWalletSettings Operation</seealso>
        /// <returns>ApiResponse of TenantWalletSettingsWrapper</returns>
        ApiResponse<TenantWalletSettingsWrapper> GetTenantWalletSettingsWithHttpInfo();
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
        /// Set wallet auto top up settings
        /// </summary>
        /// <remarks>
        /// Set the wallet auto top up settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantWalletSettingsWrapper">Tenant wallet settings (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tenant-wallet-settings/">REST API Reference for SetTenantWalletSettings Operation</seealso>
        /// <returns>TenantWalletSettingsWrapper</returns>
        TenantWalletSettingsWrapper SetTenantWalletSettings(TenantWalletSettingsWrapper? tenantWalletSettingsWrapper = default);

        /// <summary>
        /// Set wallet auto top up settings
        /// </summary>
        /// <remarks>
        /// Set the wallet auto top up settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantWalletSettingsWrapper">Tenant wallet settings (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tenant-wallet-settings/">REST API Reference for SetTenantWalletSettings Operation</seealso>
        /// <returns>ApiResponse of TenantWalletSettingsWrapper</returns>
        ApiResponse<TenantWalletSettingsWrapper> SetTenantWalletSettingsWithHttpInfo(TenantWalletSettingsWrapper? tenantWalletSettingsWrapper = default);
        /// <summary>
        /// Put money on deposit
        /// </summary>
        /// <remarks>
        /// Returns result of putting money on deposit.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topUpDepositRequestDto">Put money on deposit request parameters (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/top-up-deposit/">REST API Reference for TopUpDeposit Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper TopUpDeposit(TopUpDepositRequestDto? topUpDepositRequestDto = default);

        /// <summary>
        /// Put money on deposit
        /// </summary>
        /// <remarks>
        /// Returns result of putting money on deposit.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topUpDepositRequestDto">Put money on deposit request parameters (optional)</param>
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
        /// <param name="quantityRequestDto">The request parameters for the payment quantity specifications. (optional)</param>
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
        /// <param name="quantityRequestDto">The request parameters for the payment quantity specifications. (optional)</param>
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
        /// <param name="walletQuantityRequestDto">The request parameters for the wallet payment quantity specifications. (optional)</param>
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
        /// <param name="walletQuantityRequestDto">The request parameters for the wallet payment quantity specifications. (optional)</param>
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
        /// Calculate amount of the wallet payment
        /// </summary>
        /// <remarks>
        /// Calculate amount of the wallet payment with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The request parameters for the wallet payment quantity specifications. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/calculate-wallet-payment/">REST API Reference for CalculateWalletPayment Operation</seealso>
        /// <returns>Task of PaymentCalculationWrapper</returns>
        Task<PaymentCalculationWrapper> CalculateWalletPaymentAsync(WalletQuantityRequestDto? walletQuantityRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Calculate amount of the wallet payment
        /// </summary>
        /// <remarks>
        /// Calculate amount of the wallet payment with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The request parameters for the wallet payment quantity specifications. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/calculate-wallet-payment/">REST API Reference for CalculateWalletPayment Operation</seealso>
        /// <returns>Task of ApiResponse (PaymentCalculationWrapper)</returns>
        Task<ApiResponse<PaymentCalculationWrapper>> CalculateWalletPaymentWithHttpInfoAsync(WalletQuantityRequestDto? walletQuantityRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate the customer operations report
        /// </summary>
        /// <remarks>
        /// Generates the customer operations report as csv file and save in Documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerOperationsReportRequestDto">Parameters of the request for generating the report on client operations (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-operations-report/">REST API Reference for CreateCustomerOperationsReport Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        Task<StringWrapper> CreateCustomerOperationsReportAsync(CustomerOperationsReportRequestDto? customerOperationsReportRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate the customer operations report
        /// </summary>
        /// <remarks>
        /// Generates the customer operations report as csv file and save in Documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerOperationsReportRequestDto">Parameters of the request for generating the report on client operations (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-operations-report/">REST API Reference for CreateCustomerOperationsReport Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        Task<ApiResponse<StringWrapper>> CreateCustomerOperationsReportWithHttpInfoAsync(CustomerOperationsReportRequestDto? customerOperationsReportRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the checkout setup page URL
        /// </summary>
        /// <remarks>
        /// Returns the URL to the checkout setup page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">Back URL (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-checkout-setup-url/">REST API Reference for GetCheckoutSetupUrl Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        Task<StringWrapper> GetCheckoutSetupUrlAsync(string? backUrl = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the checkout setup page URL
        /// </summary>
        /// <remarks>
        /// Returns the URL to the checkout setup page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">Back URL (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-checkout-setup-url/">REST API Reference for GetCheckoutSetupUrl Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        Task<ApiResponse<StringWrapper>> GetCheckoutSetupUrlWithHttpInfoAsync(string? backUrl = default, CancellationToken cancellationToken = default);
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
        /// Get the customer info
        /// </summary>
        /// <remarks>
        /// Returns the customer info.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-info/">REST API Reference for GetCustomerInfo Operation</seealso>
        /// <returns>Task of CustomerInfoWrapper</returns>
        Task<CustomerInfoWrapper> GetCustomerInfoAsync(bool? refresh = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the customer info
        /// </summary>
        /// <remarks>
        /// Returns the customer info.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Specifies whether to refresh the payment information cache or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-info/">REST API Reference for GetCustomerInfo Operation</seealso>
        /// <returns>Task of ApiResponse (CustomerInfoWrapper)</returns>
        Task<ApiResponse<CustomerInfoWrapper>> GetCustomerInfoWithHttpInfoAsync(bool? refresh = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the customer operations
        /// </summary>
        /// <remarks>
        /// Returns the report of customer operations from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Start date (optional)</param>
        /// <param name="endDate">End date (optional)</param>
        /// <param name="credit">Include credit operations (true by default) (optional)</param>
        /// <param name="withdrawal">Include withdrawal operations (true by default) (optional)</param>
        /// <param name="offset">Offset (0 by default) (optional)</param>
        /// <param name="limit">Limit (25 by default) (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-operations/">REST API Reference for GetCustomerOperations Operation</seealso>
        /// <returns>Task of ReportWrapper</returns>
        Task<ReportWrapper> GetCustomerOperationsAsync(DateTime? startDate = default, DateTime? endDate = default, bool? credit = default, bool? withdrawal = default, int? offset = default, int? limit = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the customer operations
        /// </summary>
        /// <remarks>
        /// Returns the report of customer operations from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Start date (optional)</param>
        /// <param name="endDate">End date (optional)</param>
        /// <param name="credit">Include credit operations (true by default) (optional)</param>
        /// <param name="withdrawal">Include withdrawal operations (true by default) (optional)</param>
        /// <param name="offset">Offset (0 by default) (optional)</param>
        /// <param name="limit">Limit (25 by default) (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-operations/">REST API Reference for GetCustomerOperations Operation</seealso>
        /// <returns>Task of ApiResponse (ReportWrapper)</returns>
        Task<ApiResponse<ReportWrapper>> GetCustomerOperationsWithHttpInfoAsync(DateTime? startDate = default, DateTime? endDate = default, bool? credit = default, bool? withdrawal = default, int? offset = default, int? limit = default, CancellationToken cancellationToken = default);
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
        /// <param name="wallet">Get wallet quotas only (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-quotas/">REST API Reference for GetPaymentQuotas Operation</seealso>
        /// <returns>Task of QuotaArrayWrapper</returns>
        Task<QuotaArrayWrapper> GetPaymentQuotasAsync(bool? wallet = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get quotas
        /// </summary>
        /// <remarks>
        /// Returns the available portal quotas.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wallet">Get wallet quotas only (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-quotas/">REST API Reference for GetPaymentQuotas Operation</seealso>
        /// <returns>Task of ApiResponse (QuotaArrayWrapper)</returns>
        Task<ApiResponse<QuotaArrayWrapper>> GetPaymentQuotasWithHttpInfoAsync(bool? wallet = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the payment page URL
        /// </summary>
        /// <remarks>
        /// Returns the URL to the payment page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentUrlRequestsDto">The request parameters for the payment URL configuration with quantity information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-url/">REST API Reference for GetPaymentUrl Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        Task<StringWrapper> GetPaymentUrlAsync(PaymentUrlRequestsDto? paymentUrlRequestsDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the payment page URL
        /// </summary>
        /// <remarks>
        /// Returns the URL to the payment page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentUrlRequestsDto">The request parameters for the payment URL configuration with quantity information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-url/">REST API Reference for GetPaymentUrl Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        Task<ApiResponse<StringWrapper>> GetPaymentUrlWithHttpInfoAsync(PaymentUrlRequestsDto? paymentUrlRequestsDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get prices
        /// </summary>
        /// <remarks>
        /// Returns the available portal prices.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-prices/">REST API Reference for GetPortalPrices Operation</seealso>
        /// <returns>Task of ObjectWrapper</returns>
        Task<ObjectWrapper> GetPortalPricesAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get prices
        /// </summary>
        /// <remarks>
        /// Returns the available portal prices.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-prices/">REST API Reference for GetPortalPrices Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        Task<ApiResponse<ObjectWrapper>> GetPortalPricesWithHttpInfoAsync(CancellationToken cancellationToken = default);
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
        /// Get wallet auto top up settings
        /// </summary>
        /// <remarks>
        /// Returns the wallet auto top up settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-wallet-settings/">REST API Reference for GetTenantWalletSettings Operation</seealso>
        /// <returns>Task of TenantWalletSettingsWrapper</returns>
        Task<TenantWalletSettingsWrapper> GetTenantWalletSettingsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get wallet auto top up settings
        /// </summary>
        /// <remarks>
        /// Returns the wallet auto top up settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-wallet-settings/">REST API Reference for GetTenantWalletSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantWalletSettingsWrapper)</returns>
        Task<ApiResponse<TenantWalletSettingsWrapper>> GetTenantWalletSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default);
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
        /// Set wallet auto top up settings
        /// </summary>
        /// <remarks>
        /// Set the wallet auto top up settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantWalletSettingsWrapper">Tenant wallet settings (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tenant-wallet-settings/">REST API Reference for SetTenantWalletSettings Operation</seealso>
        /// <returns>Task of TenantWalletSettingsWrapper</returns>
        Task<TenantWalletSettingsWrapper> SetTenantWalletSettingsAsync(TenantWalletSettingsWrapper? tenantWalletSettingsWrapper = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Set wallet auto top up settings
        /// </summary>
        /// <remarks>
        /// Set the wallet auto top up settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantWalletSettingsWrapper">Tenant wallet settings (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tenant-wallet-settings/">REST API Reference for SetTenantWalletSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantWalletSettingsWrapper)</returns>
        Task<ApiResponse<TenantWalletSettingsWrapper>> SetTenantWalletSettingsWithHttpInfoAsync(TenantWalletSettingsWrapper? tenantWalletSettingsWrapper = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Put money on deposit
        /// </summary>
        /// <remarks>
        /// Returns result of putting money on deposit.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topUpDepositRequestDto">Put money on deposit request parameters (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/top-up-deposit/">REST API Reference for TopUpDeposit Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        Task<BooleanWrapper> TopUpDepositAsync(TopUpDepositRequestDto? topUpDepositRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Put money on deposit
        /// </summary>
        /// <remarks>
        /// Returns result of putting money on deposit.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topUpDepositRequestDto">Put money on deposit request parameters (optional)</param>
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
        /// <param name="quantityRequestDto">The request parameters for the payment quantity specifications. (optional)</param>
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
        /// <param name="quantityRequestDto">The request parameters for the payment quantity specifications. (optional)</param>
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
        /// <param name="walletQuantityRequestDto">The request parameters for the wallet payment quantity specifications. (optional)</param>
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
        /// <param name="walletQuantityRequestDto">The request parameters for the wallet payment quantity specifications. (optional)</param>
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
        /// Calculate amount of the wallet payment
        /// </summary>
        /// <remarks>
        /// Calculate amount of the wallet payment with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The request parameters for the wallet payment quantity specifications. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/calculate-wallet-payment/">REST API Reference for CalculateWalletPayment Operation</seealso>
        /// <returns>PaymentCalculationWrapper</returns>
        public PaymentCalculationWrapper CalculateWalletPayment(WalletQuantityRequestDto? walletQuantityRequestDto = default)
        {
            var localVarResponse = CalculateWalletPaymentWithHttpInfo(walletQuantityRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Calculate amount of the wallet payment
        /// </summary>
        /// <remarks>
        /// Calculate amount of the wallet payment with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The request parameters for the wallet payment quantity specifications. (optional)</param>
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
        /// Calculate amount of the wallet payment
        /// </summary>
        /// <remarks>
        /// Calculate amount of the wallet payment with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The request parameters for the wallet payment quantity specifications. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/calculate-wallet-payment/">REST API Reference for CalculateWalletPayment Operation</seealso>
        /// <returns>Task of PaymentCalculationWrapper</returns>
        public async Task<PaymentCalculationWrapper> CalculateWalletPaymentAsync(WalletQuantityRequestDto? walletQuantityRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CalculateWalletPaymentWithHttpInfoAsync(walletQuantityRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Calculate amount of the wallet payment
        /// </summary>
        /// <remarks>
        /// Calculate amount of the wallet payment with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The request parameters for the wallet payment quantity specifications. (optional)</param>
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
        /// Generate the customer operations report
        /// </summary>
        /// <remarks>
        /// Generates the customer operations report as csv file and save in Documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerOperationsReportRequestDto">Parameters of the request for generating the report on client operations (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-operations-report/">REST API Reference for CreateCustomerOperationsReport Operation</seealso>
        /// <returns>StringWrapper</returns>
        public StringWrapper CreateCustomerOperationsReport(CustomerOperationsReportRequestDto? customerOperationsReportRequestDto = default)
        {
            var localVarResponse = CreateCustomerOperationsReportWithHttpInfo(customerOperationsReportRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Generate the customer operations report
        /// </summary>
        /// <remarks>
        /// Generates the customer operations report as csv file and save in Documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerOperationsReportRequestDto">Parameters of the request for generating the report on client operations (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-operations-report/">REST API Reference for CreateCustomerOperationsReport Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        public ApiResponse<StringWrapper> CreateCustomerOperationsReportWithHttpInfo(CustomerOperationsReportRequestDto? customerOperationsReportRequestDto = default)
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
            var localVarResponse = Client.Post<StringWrapper>("/api/2.0/portal/payment/customer/operationsreport", localVarRequestOptions, Configuration);

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
        /// Generate the customer operations report
        /// </summary>
        /// <remarks>
        /// Generates the customer operations report as csv file and save in Documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerOperationsReportRequestDto">Parameters of the request for generating the report on client operations (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-operations-report/">REST API Reference for CreateCustomerOperationsReport Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        public async Task<StringWrapper> CreateCustomerOperationsReportAsync(CustomerOperationsReportRequestDto? customerOperationsReportRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateCustomerOperationsReportWithHttpInfoAsync(customerOperationsReportRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Generate the customer operations report
        /// </summary>
        /// <remarks>
        /// Generates the customer operations report as csv file and save in Documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerOperationsReportRequestDto">Parameters of the request for generating the report on client operations (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-operations-report/">REST API Reference for CreateCustomerOperationsReport Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        public async Task<ApiResponse<StringWrapper>> CreateCustomerOperationsReportWithHttpInfoAsync(CustomerOperationsReportRequestDto? customerOperationsReportRequestDto = default, CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.PostAsync<StringWrapper>("/api/2.0/portal/payment/customer/operationsreport", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

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
        /// Get the checkout setup page URL
        /// </summary>
        /// <remarks>
        /// Returns the URL to the checkout setup page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">Back URL (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-checkout-setup-url/">REST API Reference for GetCheckoutSetupUrl Operation</seealso>
        /// <returns>StringWrapper</returns>
        public StringWrapper GetCheckoutSetupUrl(string? backUrl = default)
        {
            var localVarResponse = GetCheckoutSetupUrlWithHttpInfo(backUrl);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the checkout setup page URL
        /// </summary>
        /// <remarks>
        /// Returns the URL to the checkout setup page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">Back URL (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-checkout-setup-url/">REST API Reference for GetCheckoutSetupUrl Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        public ApiResponse<StringWrapper> GetCheckoutSetupUrlWithHttpInfo(string? backUrl = default)
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
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "BackUrl", backUrl));
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
            var localVarResponse = Client.Get<StringWrapper>("/api/2.0/portal/payment/chechoutsetupurl", localVarRequestOptions, Configuration);

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
        /// <param name="backUrl">Back URL (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-checkout-setup-url/">REST API Reference for GetCheckoutSetupUrl Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        public async Task<StringWrapper> GetCheckoutSetupUrlAsync(string? backUrl = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetCheckoutSetupUrlWithHttpInfoAsync(backUrl, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the checkout setup page URL
        /// </summary>
        /// <remarks>
        /// Returns the URL to the checkout setup page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">Back URL (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-checkout-setup-url/">REST API Reference for GetCheckoutSetupUrl Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        public async Task<ApiResponse<StringWrapper>> GetCheckoutSetupUrlWithHttpInfoAsync(string? backUrl = default, CancellationToken cancellationToken = default)
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
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "BackUrl", backUrl));
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

            var localVarResponse = await AsynchronousClient.GetAsync<StringWrapper>("/api/2.0/portal/payment/chechoutsetupurl", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

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
        /// Get the customer info
        /// </summary>
        /// <remarks>
        /// Returns the customer info.
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
        /// Get the customer info
        /// </summary>
        /// <remarks>
        /// Returns the customer info.
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
        /// Get the customer info
        /// </summary>
        /// <remarks>
        /// Returns the customer info.
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
        /// Get the customer info
        /// </summary>
        /// <remarks>
        /// Returns the customer info.
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
        /// Get the customer operations
        /// </summary>
        /// <remarks>
        /// Returns the report of customer operations from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Start date (optional)</param>
        /// <param name="endDate">End date (optional)</param>
        /// <param name="credit">Include credit operations (true by default) (optional)</param>
        /// <param name="withdrawal">Include withdrawal operations (true by default) (optional)</param>
        /// <param name="offset">Offset (0 by default) (optional)</param>
        /// <param name="limit">Limit (25 by default) (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-operations/">REST API Reference for GetCustomerOperations Operation</seealso>
        /// <returns>ReportWrapper</returns>
        public ReportWrapper GetCustomerOperations(DateTime? startDate = default, DateTime? endDate = default, bool? credit = default, bool? withdrawal = default, int? offset = default, int? limit = default)
        {
            var localVarResponse = GetCustomerOperationsWithHttpInfo(startDate, endDate, credit, withdrawal, offset, limit);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the customer operations
        /// </summary>
        /// <remarks>
        /// Returns the report of customer operations from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Start date (optional)</param>
        /// <param name="endDate">End date (optional)</param>
        /// <param name="credit">Include credit operations (true by default) (optional)</param>
        /// <param name="withdrawal">Include withdrawal operations (true by default) (optional)</param>
        /// <param name="offset">Offset (0 by default) (optional)</param>
        /// <param name="limit">Limit (25 by default) (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-operations/">REST API Reference for GetCustomerOperations Operation</seealso>
        /// <returns>ApiResponse of ReportWrapper</returns>
        public ApiResponse<ReportWrapper> GetCustomerOperationsWithHttpInfo(DateTime? startDate = default, DateTime? endDate = default, bool? credit = default, bool? withdrawal = default, int? offset = default, int? limit = default)
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
            if (credit != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "credit", credit));
            }
            if (withdrawal != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "withdrawal", withdrawal));
            }
            if (offset != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "offset", offset));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "limit", limit));
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
        /// <param name="startDate">Start date (optional)</param>
        /// <param name="endDate">End date (optional)</param>
        /// <param name="credit">Include credit operations (true by default) (optional)</param>
        /// <param name="withdrawal">Include withdrawal operations (true by default) (optional)</param>
        /// <param name="offset">Offset (0 by default) (optional)</param>
        /// <param name="limit">Limit (25 by default) (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-operations/">REST API Reference for GetCustomerOperations Operation</seealso>
        /// <returns>Task of ReportWrapper</returns>
        public async Task<ReportWrapper> GetCustomerOperationsAsync(DateTime? startDate = default, DateTime? endDate = default, bool? credit = default, bool? withdrawal = default, int? offset = default, int? limit = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetCustomerOperationsWithHttpInfoAsync(startDate, endDate, credit, withdrawal, offset, limit, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the customer operations
        /// </summary>
        /// <remarks>
        /// Returns the report of customer operations from the accounting service.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Start date (optional)</param>
        /// <param name="endDate">End date (optional)</param>
        /// <param name="credit">Include credit operations (true by default) (optional)</param>
        /// <param name="withdrawal">Include withdrawal operations (true by default) (optional)</param>
        /// <param name="offset">Offset (0 by default) (optional)</param>
        /// <param name="limit">Limit (25 by default) (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-operations/">REST API Reference for GetCustomerOperations Operation</seealso>
        /// <returns>Task of ApiResponse (ReportWrapper)</returns>
        public async Task<ApiResponse<ReportWrapper>> GetCustomerOperationsWithHttpInfoAsync(DateTime? startDate = default, DateTime? endDate = default, bool? credit = default, bool? withdrawal = default, int? offset = default, int? limit = default, CancellationToken cancellationToken = default)
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
            if (credit != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "credit", credit));
            }
            if (withdrawal != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "withdrawal", withdrawal));
            }
            if (offset != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "offset", offset));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "limit", limit));
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
        /// <param name="wallet">Get wallet quotas only (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-quotas/">REST API Reference for GetPaymentQuotas Operation</seealso>
        /// <returns>QuotaArrayWrapper</returns>
        public QuotaArrayWrapper GetPaymentQuotas(bool? wallet = default)
        {
            var localVarResponse = GetPaymentQuotasWithHttpInfo(wallet);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get quotas
        /// </summary>
        /// <remarks>
        /// Returns the available portal quotas.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wallet">Get wallet quotas only (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-quotas/">REST API Reference for GetPaymentQuotas Operation</seealso>
        /// <returns>ApiResponse of QuotaArrayWrapper</returns>
        public ApiResponse<QuotaArrayWrapper> GetPaymentQuotasWithHttpInfo(bool? wallet = default)
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
        /// <param name="wallet">Get wallet quotas only (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-quotas/">REST API Reference for GetPaymentQuotas Operation</seealso>
        /// <returns>Task of QuotaArrayWrapper</returns>
        public async Task<QuotaArrayWrapper> GetPaymentQuotasAsync(bool? wallet = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetPaymentQuotasWithHttpInfoAsync(wallet, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get quotas
        /// </summary>
        /// <remarks>
        /// Returns the available portal quotas.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wallet">Get wallet quotas only (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-quotas/">REST API Reference for GetPaymentQuotas Operation</seealso>
        /// <returns>Task of ApiResponse (QuotaArrayWrapper)</returns>
        public async Task<ApiResponse<QuotaArrayWrapper>> GetPaymentQuotasWithHttpInfoAsync(bool? wallet = default, CancellationToken cancellationToken = default)
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
        /// <param name="paymentUrlRequestsDto">The request parameters for the payment URL configuration with quantity information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-url/">REST API Reference for GetPaymentUrl Operation</seealso>
        /// <returns>StringWrapper</returns>
        public StringWrapper GetPaymentUrl(PaymentUrlRequestsDto? paymentUrlRequestsDto = default)
        {
            var localVarResponse = GetPaymentUrlWithHttpInfo(paymentUrlRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the payment page URL
        /// </summary>
        /// <remarks>
        /// Returns the URL to the payment page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentUrlRequestsDto">The request parameters for the payment URL configuration with quantity information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-url/">REST API Reference for GetPaymentUrl Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        public ApiResponse<StringWrapper> GetPaymentUrlWithHttpInfo(PaymentUrlRequestsDto? paymentUrlRequestsDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (paymentUrlRequestsDto != null) localVarRequestOptions.Data = paymentUrlRequestsDto;

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
        /// <param name="paymentUrlRequestsDto">The request parameters for the payment URL configuration with quantity information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-url/">REST API Reference for GetPaymentUrl Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        public async Task<StringWrapper> GetPaymentUrlAsync(PaymentUrlRequestsDto? paymentUrlRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetPaymentUrlWithHttpInfoAsync(paymentUrlRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the payment page URL
        /// </summary>
        /// <remarks>
        /// Returns the URL to the payment page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentUrlRequestsDto">The request parameters for the payment URL configuration with quantity information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-url/">REST API Reference for GetPaymentUrl Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        public async Task<ApiResponse<StringWrapper>> GetPaymentUrlWithHttpInfoAsync(PaymentUrlRequestsDto? paymentUrlRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (paymentUrlRequestsDto != null) localVarRequestOptions.Data = paymentUrlRequestsDto;

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
        /// <returns>ObjectWrapper</returns>
        public ObjectWrapper GetPortalPrices()
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
        /// <returns>ApiResponse of ObjectWrapper</returns>
        public ApiResponse<ObjectWrapper> GetPortalPricesWithHttpInfo()
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
            var localVarResponse = Client.Get<ObjectWrapper>("/api/2.0/portal/payment/prices", localVarRequestOptions, Configuration);

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
        /// <returns>Task of ObjectWrapper</returns>
        public async Task<ObjectWrapper> GetPortalPricesAsync(CancellationToken cancellationToken = default)
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
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        public async Task<ApiResponse<ObjectWrapper>> GetPortalPricesWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<ObjectWrapper>("/api/2.0/portal/payment/prices", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

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
        /// Get wallet auto top up settings
        /// </summary>
        /// <remarks>
        /// Returns the wallet auto top up settings.
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
        /// Get wallet auto top up settings
        /// </summary>
        /// <remarks>
        /// Returns the wallet auto top up settings.
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
        /// Get wallet auto top up settings
        /// </summary>
        /// <remarks>
        /// Returns the wallet auto top up settings.
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
        /// Get wallet auto top up settings
        /// </summary>
        /// <remarks>
        /// Returns the wallet auto top up settings.
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
        /// Set wallet auto top up settings
        /// </summary>
        /// <remarks>
        /// Set the wallet auto top up settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantWalletSettingsWrapper">Tenant wallet settings (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tenant-wallet-settings/">REST API Reference for SetTenantWalletSettings Operation</seealso>
        /// <returns>TenantWalletSettingsWrapper</returns>
        public TenantWalletSettingsWrapper SetTenantWalletSettings(TenantWalletSettingsWrapper? tenantWalletSettingsWrapper = default)
        {
            var localVarResponse = SetTenantWalletSettingsWithHttpInfo(tenantWalletSettingsWrapper);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set wallet auto top up settings
        /// </summary>
        /// <remarks>
        /// Set the wallet auto top up settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantWalletSettingsWrapper">Tenant wallet settings (optional)</param>
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
        /// Set wallet auto top up settings
        /// </summary>
        /// <remarks>
        /// Set the wallet auto top up settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantWalletSettingsWrapper">Tenant wallet settings (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tenant-wallet-settings/">REST API Reference for SetTenantWalletSettings Operation</seealso>
        /// <returns>Task of TenantWalletSettingsWrapper</returns>
        public async Task<TenantWalletSettingsWrapper> SetTenantWalletSettingsAsync(TenantWalletSettingsWrapper? tenantWalletSettingsWrapper = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetTenantWalletSettingsWithHttpInfoAsync(tenantWalletSettingsWrapper, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set wallet auto top up settings
        /// </summary>
        /// <remarks>
        /// Set the wallet auto top up settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantWalletSettingsWrapper">Tenant wallet settings (optional)</param>
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
        /// Put money on deposit
        /// </summary>
        /// <remarks>
        /// Returns result of putting money on deposit.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topUpDepositRequestDto">Put money on deposit request parameters (optional)</param>
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
        /// Returns result of putting money on deposit.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topUpDepositRequestDto">Put money on deposit request parameters (optional)</param>
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
        /// Returns result of putting money on deposit.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topUpDepositRequestDto">Put money on deposit request parameters (optional)</param>
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
        /// Returns result of putting money on deposit.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topUpDepositRequestDto">Put money on deposit request parameters (optional)</param>
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
        /// <param name="quantityRequestDto">The request parameters for the payment quantity specifications. (optional)</param>
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
        /// <param name="quantityRequestDto">The request parameters for the payment quantity specifications. (optional)</param>
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
        /// <param name="quantityRequestDto">The request parameters for the payment quantity specifications. (optional)</param>
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
        /// <param name="quantityRequestDto">The request parameters for the payment quantity specifications. (optional)</param>
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
        /// <param name="walletQuantityRequestDto">The request parameters for the wallet payment quantity specifications. (optional)</param>
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
        /// <param name="walletQuantityRequestDto">The request parameters for the wallet payment quantity specifications. (optional)</param>
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
        /// <param name="walletQuantityRequestDto">The request parameters for the wallet payment quantity specifications. (optional)</param>
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
        /// <param name="walletQuantityRequestDto">The request parameters for the wallet payment quantity specifications. (optional)</param>
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
