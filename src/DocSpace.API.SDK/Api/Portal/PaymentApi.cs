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
        /// Prices a wallet-service purchase without making it: it returns what buying the requested number of units would  cost right now, so a client can show the amount before asking for a confirmation. Only `productQuantityType`  `Add` (1) is accepted, the quantity must be greater than zero, and the portal needs a billing customer whose  wallet has a sub-account in the accounting currency. The caller has to be a DocSpace administrator. Nothing is  bought, charged or written down - the call is read-only and may be repeated - and the purchase itself is  `PUT api/2.0/portal/payment/updatewallet`. The answer carries the amount with its currency, the quantity it  was computed for and the identifier of the calculation. It is the price of this moment and is not held: it can  differ by the time the purchase is made.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The wallet service being bought or scheduled, and the way its quantity is applied. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/calculate-wallet-payment/">REST API Reference for CalculateWalletPayment Operation</seealso>
        /// <returns>PaymentCalculationWrapper</returns>
        PaymentCalculationWrapper CalculateWalletPayment(WalletQuantityRequestDto? walletQuantityRequestDto = default);

        /// <summary>
        /// Calculate the wallet payment amount
        /// </summary>
        /// <remarks>
        /// Prices a wallet-service purchase without making it: it returns what buying the requested number of units would  cost right now, so a client can show the amount before asking for a confirmation. Only `productQuantityType`  `Add` (1) is accepted, the quantity must be greater than zero, and the portal needs a billing customer whose  wallet has a sub-account in the accounting currency. The caller has to be a DocSpace administrator. Nothing is  bought, charged or written down - the call is read-only and may be repeated - and the purchase itself is  `PUT api/2.0/portal/payment/updatewallet`. The answer carries the amount with its currency, the quantity it  was computed for and the identifier of the calculation. It is the price of this moment and is not held: it can  differ by the time the purchase is made.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The wallet service being bought or scheduled, and the way its quantity is applied. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/calculate-wallet-payment/">REST API Reference for CalculateWalletPayment Operation</seealso>
        /// <returns>ApiResponse of PaymentCalculationWrapper</returns>
        ApiResponse<PaymentCalculationWrapper> CalculateWalletPaymentWithHttpInfo(WalletQuantityRequestDto? walletQuantityRequestDto = default);
        /// <summary>
        /// Switch a wallet service
        /// </summary>
        /// <remarks>
        /// Switches one wallet service on or off for the portal: `service` names it and `enabled` says which way. The  portal needs a billing customer, and the caller needs both the permission to edit the portal settings and  DocSpace administrator rights. Order matters between the two AI services - AI tools has to be on before AI  search may be switched on, and switching AI tools off switches AI search off with it - so a request that  breaks that order is refused with 403. The call is mutating and idempotent: switching on a service that is  already on changes nothing. It is written to the portal audit trail, and switching AI tools notifies the  portal clients so the AI features appear or disappear for them without a reload. The whole updated set of  switched-on services comes back. Switching a service on does not buy it - its units are still bought with  `PUT api/2.0/portal/payment/updatewallet`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="changeWalletServiceStateRequestDto">Which wallet service is switched, and which way. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-tenant-wallet-service-state/">REST API Reference for ChangeTenantWalletServiceState Operation</seealso>
        /// <returns>TenantWalletServiceSettingsWrapper</returns>
        TenantWalletServiceSettingsWrapper ChangeTenantWalletServiceState(ChangeWalletServiceStateRequestDto? changeWalletServiceStateRequestDto = default);

        /// <summary>
        /// Switch a wallet service
        /// </summary>
        /// <remarks>
        /// Switches one wallet service on or off for the portal: `service` names it and `enabled` says which way. The  portal needs a billing customer, and the caller needs both the permission to edit the portal settings and  DocSpace administrator rights. Order matters between the two AI services - AI tools has to be on before AI  search may be switched on, and switching AI tools off switches AI search off with it - so a request that  breaks that order is refused with 403. The call is mutating and idempotent: switching on a service that is  already on changes nothing. It is written to the portal audit trail, and switching AI tools notifies the  portal clients so the AI features appear or disappear for them without a reload. The whole updated set of  switched-on services comes back. Switching a service on does not buy it - its units are still bought with  `PUT api/2.0/portal/payment/updatewallet`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="changeWalletServiceStateRequestDto">Which wallet service is switched, and which way. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-tenant-wallet-service-state/">REST API Reference for ChangeTenantWalletServiceState Operation</seealso>
        /// <returns>ApiResponse of TenantWalletServiceSettingsWrapper</returns>
        ApiResponse<TenantWalletServiceSettingsWrapper> ChangeTenantWalletServiceStateWithHttpInfo(ChangeWalletServiceStateRequestDto? changeWalletServiceStateRequestDto = default);
        /// <summary>
        /// Start the monthly usage report
        /// </summary>
        /// <remarks>
        /// Queues the wallet spending added up per calendar month as an `xlsx` file and returns the task that will build  it; the file is not ready when the response arrives. The portal needs a billing customer and the caller has to  be a DocSpace administrator. The body takes only the period - `startDate` and `endDate`, both inclusive - and  an empty body covers everything from the portal creation date to now; the months are cut in the portal time  zone, exactly as in `GET api/2.0/portal/payment/customer/usage/monthly`. Poll  `GET api/2.0/portal/payment/customer/usage/monthly/report` until `isCompleted` is true, then take the file  from `resultFileUrl` or open `resultFileId`: the finished file is saved into the caller's own My documents  section, where it counts against the portal storage like any other file. One monthly usage report per user is  tracked at a time - a call made while the previous one is still running answers with that task - and  `DELETE api/2.0/portal/payment/customer/usage/monthly/report` stops it. There is no service filter here: for a  report per service use `POST api/2.0/portal/payment/customer/usage/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerMonthlyUsageReportRequestDto">The period covered by the monthly wallet spending report. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-monthly-usage-report/">REST API Reference for CreateCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>DocumentBuilderTaskWrapper</returns>
        DocumentBuilderTaskWrapper CreateCustomerMonthlyUsageReport(CustomerMonthlyUsageReportRequestDto? customerMonthlyUsageReportRequestDto = default);

        /// <summary>
        /// Start the monthly usage report
        /// </summary>
        /// <remarks>
        /// Queues the wallet spending added up per calendar month as an `xlsx` file and returns the task that will build  it; the file is not ready when the response arrives. The portal needs a billing customer and the caller has to  be a DocSpace administrator. The body takes only the period - `startDate` and `endDate`, both inclusive - and  an empty body covers everything from the portal creation date to now; the months are cut in the portal time  zone, exactly as in `GET api/2.0/portal/payment/customer/usage/monthly`. Poll  `GET api/2.0/portal/payment/customer/usage/monthly/report` until `isCompleted` is true, then take the file  from `resultFileUrl` or open `resultFileId`: the finished file is saved into the caller's own My documents  section, where it counts against the portal storage like any other file. One monthly usage report per user is  tracked at a time - a call made while the previous one is still running answers with that task - and  `DELETE api/2.0/portal/payment/customer/usage/monthly/report` stops it. There is no service filter here: for a  report per service use `POST api/2.0/portal/payment/customer/usage/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerMonthlyUsageReportRequestDto">The period covered by the monthly wallet spending report. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-monthly-usage-report/">REST API Reference for CreateCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>ApiResponse of DocumentBuilderTaskWrapper</returns>
        ApiResponse<DocumentBuilderTaskWrapper> CreateCustomerMonthlyUsageReportWithHttpInfo(CustomerMonthlyUsageReportRequestDto? customerMonthlyUsageReportRequestDto = default);
        /// <summary>
        /// Start the operations report
        /// </summary>
        /// <remarks>
        /// Queues the history of the wallet movements as an `xlsx` file and returns the task that will build it; the file  is not ready when the response arrives. The portal needs a billing customer and the caller has to be a  DocSpace administrator. The body takes the same filters as `GET api/2.0/portal/payment/customer/operations` -  the service names, the date range, the participant, the operation type and status, the credit and debit  directions and the ordering - and an empty body reports everything from the portal creation date to now; a  service name this installation does not sell fails with 404. Poll  `GET api/2.0/portal/payment/customer/operationsreport` until `isCompleted` is true, then take the file from  `resultFileUrl` or open `resultFileId`: the finished file is saved into the caller's own My documents section,  where it counts against the portal storage like any other file. One operations report per user is tracked at a  time - a call made while the previous one is still running answers with that task - and  `DELETE api/2.0/portal/payment/customer/operationsreport` stops it. A build that fails ends the task with  `error` filled in rather than failing this call.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerOperationsReportRequestDto">The filters that select which wallet movements are reported: the services, the period, the participant, the  direction and the outcome of the movement, and the ordering. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-operations-report/">REST API Reference for CreateCustomerOperationsReport Operation</seealso>
        /// <returns>DocumentBuilderTaskWrapper</returns>
        DocumentBuilderTaskWrapper CreateCustomerOperationsReport(CustomerOperationsReportRequestDto? customerOperationsReportRequestDto = default);

        /// <summary>
        /// Start the operations report
        /// </summary>
        /// <remarks>
        /// Queues the history of the wallet movements as an `xlsx` file and returns the task that will build it; the file  is not ready when the response arrives. The portal needs a billing customer and the caller has to be a  DocSpace administrator. The body takes the same filters as `GET api/2.0/portal/payment/customer/operations` -  the service names, the date range, the participant, the operation type and status, the credit and debit  directions and the ordering - and an empty body reports everything from the portal creation date to now; a  service name this installation does not sell fails with 404. Poll  `GET api/2.0/portal/payment/customer/operationsreport` until `isCompleted` is true, then take the file from  `resultFileUrl` or open `resultFileId`: the finished file is saved into the caller's own My documents section,  where it counts against the portal storage like any other file. One operations report per user is tracked at a  time - a call made while the previous one is still running answers with that task - and  `DELETE api/2.0/portal/payment/customer/operationsreport` stops it. A build that fails ends the task with  `error` filled in rather than failing this call.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerOperationsReportRequestDto">The filters that select which wallet movements are reported: the services, the period, the participant, the  direction and the outcome of the movement, and the ordering. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-operations-report/">REST API Reference for CreateCustomerOperationsReport Operation</seealso>
        /// <returns>ApiResponse of DocumentBuilderTaskWrapper</returns>
        ApiResponse<DocumentBuilderTaskWrapper> CreateCustomerOperationsReportWithHttpInfo(CustomerOperationsReportRequestDto? customerOperationsReportRequestDto = default);
        /// <summary>
        /// Start the service usage report
        /// </summary>
        /// <remarks>
        /// Queues the usage of the wallet services as an `xlsx` file and returns the task that will build it; the file is  not ready when the response arrives. The portal needs a billing customer and the caller has to be a DocSpace  administrator. The body takes the same filters as `GET api/2.0/portal/payment/customer/usage` - the service  names, the date range, the participant, the operation status, the usage metadata and the ordering - and an  empty body reports every service from the portal creation date to now; a service name this installation does  not sell fails with 404. Poll `GET api/2.0/portal/payment/customer/usage/report` until `isCompleted` is true,  then take the file from `resultFileUrl` or open `resultFileId`: the finished file is saved into the caller's  own My documents section, where it counts against the portal storage like any other file. One service usage  report per user is tracked at a time - a call made while the previous one is still running answers with that  task - and `DELETE api/2.0/portal/payment/customer/usage/report` stops it. It is a different report from the  operations one and does not interfere with it: per-movement history is  `POST api/2.0/portal/payment/customer/operationsreport`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerServiceUsageReportRequestDto">The filters that select which wallet service consumption is reported: the services, the period, the participant,  the outcome, the usage metadata and the ordering. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-service-usage-report/">REST API Reference for CreateCustomerServiceUsageReport Operation</seealso>
        /// <returns>DocumentBuilderTaskWrapper</returns>
        DocumentBuilderTaskWrapper CreateCustomerServiceUsageReport(CustomerServiceUsageReportRequestDto? customerServiceUsageReportRequestDto = default);

        /// <summary>
        /// Start the service usage report
        /// </summary>
        /// <remarks>
        /// Queues the usage of the wallet services as an `xlsx` file and returns the task that will build it; the file is  not ready when the response arrives. The portal needs a billing customer and the caller has to be a DocSpace  administrator. The body takes the same filters as `GET api/2.0/portal/payment/customer/usage` - the service  names, the date range, the participant, the operation status, the usage metadata and the ordering - and an  empty body reports every service from the portal creation date to now; a service name this installation does  not sell fails with 404. Poll `GET api/2.0/portal/payment/customer/usage/report` until `isCompleted` is true,  then take the file from `resultFileUrl` or open `resultFileId`: the finished file is saved into the caller's  own My documents section, where it counts against the portal storage like any other file. One service usage  report per user is tracked at a time - a call made while the previous one is still running answers with that  task - and `DELETE api/2.0/portal/payment/customer/usage/report` stops it. It is a different report from the  operations one and does not interfere with it: per-movement history is  `POST api/2.0/portal/payment/customer/operationsreport`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerServiceUsageReportRequestDto">The filters that select which wallet service consumption is reported: the services, the period, the participant,  the outcome, the usage metadata and the ordering. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-service-usage-report/">REST API Reference for CreateCustomerServiceUsageReport Operation</seealso>
        /// <returns>ApiResponse of DocumentBuilderTaskWrapper</returns>
        ApiResponse<DocumentBuilderTaskWrapper> CreateCustomerServiceUsageReportWithHttpInfo(CustomerServiceUsageReportRequestDto? customerServiceUsageReportRequestDto = default);
        /// <summary>
        /// Get the service prices from the accounting service
        /// </summary>
        /// <remarks>
        /// Returns the portal's automatic wallet top-up settings: whether it is switched on, the balance that triggers  it, the balance it tops the wallet up to and the currency it charges in. Only a DocSpace administrator may  read it, no billing customer is needed, and the call is read-only. A portal that has never configured it gets  the defaults rather than an empty result, so `enabled` is the field that says whether anything happens at all.  Two of the values are kept by the portal itself and cannot be set through this API: `lowBalanceThreshold` is  the balance below which the portal warns its administrators by mail, and `lowBalanceNotified` says whether  that warning has already gone out for the current dip. Change the rest with  `POST api/2.0/portal/payment/topupsettings`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName">The service whose price list is read, named the way the billing catalogue names it, such as `ai-tools` or  `backup`. Take the value from the `serviceName` field of `GET api/2.0/portal/payment/walletservices`; a name  the accounting service does not price yields an empty list rather than an error.</param>
        /// <param name="active">Whether the answer is narrowed to the prices in force at the moment of the call. Leaving it false also  returns the retired and the not yet started ones, which is what pricing a movement recorded in the past  needs. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounting-service-prices/">REST API Reference for GetAccountingServicePrices Operation</seealso>
        /// <returns>ServicePriceInfoArrayWrapper</returns>
        ServicePriceInfoArrayWrapper GetAccountingServicePrices(string serviceName, bool? active = default);

        /// <summary>
        /// Get the service prices from the accounting service
        /// </summary>
        /// <remarks>
        /// Returns the portal's automatic wallet top-up settings: whether it is switched on, the balance that triggers  it, the balance it tops the wallet up to and the currency it charges in. Only a DocSpace administrator may  read it, no billing customer is needed, and the call is read-only. A portal that has never configured it gets  the defaults rather than an empty result, so `enabled` is the field that says whether anything happens at all.  Two of the values are kept by the portal itself and cannot be set through this API: `lowBalanceThreshold` is  the balance below which the portal warns its administrators by mail, and `lowBalanceNotified` says whether  that warning has already gone out for the current dip. Change the rest with  `POST api/2.0/portal/payment/topupsettings`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName">The service whose price list is read, named the way the billing catalogue names it, such as `ai-tools` or  `backup`. Take the value from the `serviceName` field of `GET api/2.0/portal/payment/walletservices`; a name  the accounting service does not price yields an empty list rather than an error.</param>
        /// <param name="active">Whether the answer is narrowed to the prices in force at the moment of the call. Leaving it false also  returns the retired and the not yet started ones, which is what pricing a movement recorded in the past  needs. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounting-service-prices/">REST API Reference for GetAccountingServicePrices Operation</seealso>
        /// <returns>ApiResponse of ServicePriceInfoArrayWrapper</returns>
        ApiResponse<ServicePriceInfoArrayWrapper> GetAccountingServicePricesWithHttpInfo(string serviceName, bool? active = default);
        /// <summary>
        /// Get the active wallet services
        /// </summary>
        /// <remarks>
        /// Lists the wallet services the portal is running right now: the add-ons its plan pays for that are in the  active state, plus the ones an administrator switched on by hand in the wallet service settings; the DocsCloud  trial is listed as well, although it is not paid from the wallet. Only a DocSpace administrator may call it,  no billing customer is needed for it, and the call is read-only. Every item names the service, its title and  the unit it is measured in, and says whether it is a subscription; a subscribed service also carries the limit  it grants and how much of it is used where that number is known - the editor seats and the editors currently  active for DocsCloud, the purchased units and the units already consumed for disk storage. A service listed  with no limit is one whose usage is not counted this way, not one without a limit. The catalogue of what could  be switched on is `GET api/2.0/portal/payment/walletservices`, and switching one is  `POST api/2.0/portal/payment/servicestate`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-active-services/">REST API Reference for GetActiveServices Operation</seealso>
        /// <returns>ActiveServiceArrayWrapper</returns>
        ActiveServiceArrayWrapper GetActiveServices();

        /// <summary>
        /// Get the active wallet services
        /// </summary>
        /// <remarks>
        /// Lists the wallet services the portal is running right now: the add-ons its plan pays for that are in the  active state, plus the ones an administrator switched on by hand in the wallet service settings; the DocsCloud  trial is listed as well, although it is not paid from the wallet. Only a DocSpace administrator may call it,  no billing customer is needed for it, and the call is read-only. Every item names the service, its title and  the unit it is measured in, and says whether it is a subscription; a subscribed service also carries the limit  it grants and how much of it is used where that number is known - the editor seats and the editors currently  active for DocsCloud, the purchased units and the units already consumed for disk storage. A service listed  with no limit is one whose usage is not counted this way, not one without a limit. The catalogue of what could  be switched on is `GET api/2.0/portal/payment/walletservices`, and switching one is  `POST api/2.0/portal/payment/servicestate`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-active-services/">REST API Reference for GetActiveServices Operation</seealso>
        /// <returns>ApiResponse of ActiveServiceArrayWrapper</returns>
        ApiResponse<ActiveServiceArrayWrapper> GetActiveServicesWithHttpInfo();
        /// <summary>
        /// Get AI model prices
        /// </summary>
        /// <remarks>
        /// Returns the price list of the AI features the portal pays for out of its wallet: the chat models with the  price of their prompt and completion tokens, the embedding models, the image models with their per-image  price, and the web search providers with the price of one search. The installation needs both a billing  service and the AI gateway configured, otherwise the answer is 403, and only a DocSpace administrator may read  it; the call is read-only. Token prices are normalised per million tokens, and every price is in the single  `currency` the answer names. Each entry carries the model identifier to use when talking to the AI operations,  its display alias, its provider with the provider icon, and a link to the model's own page. It is a list of  what the models cost and not of what the portal spent - that is `GET api/2.0/portal/payment/customer/usage` -  and it says nothing about which of them are allowed here, which is  `GET api/2.0/portal/payment/ai-model/restrictions`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-ai-prices/">REST API Reference for GetAiPrices Operation</seealso>
        /// <returns>AiPricesWrapper</returns>
        AiPricesWrapper GetAiPrices();

        /// <summary>
        /// Get AI model prices
        /// </summary>
        /// <remarks>
        /// Returns the price list of the AI features the portal pays for out of its wallet: the chat models with the  price of their prompt and completion tokens, the embedding models, the image models with their per-image  price, and the web search providers with the price of one search. The installation needs both a billing  service and the AI gateway configured, otherwise the answer is 403, and only a DocSpace administrator may read  it; the call is read-only. Token prices are normalised per million tokens, and every price is in the single  `currency` the answer names. Each entry carries the model identifier to use when talking to the AI operations,  its display alias, its provider with the provider icon, and a link to the model's own page. It is a list of  what the models cost and not of what the portal spent - that is `GET api/2.0/portal/payment/customer/usage` -  and it says nothing about which of them are allowed here, which is  `GET api/2.0/portal/payment/ai-model/restrictions`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-ai-prices/">REST API Reference for GetAiPrices Operation</seealso>
        /// <returns>ApiResponse of AiPricesWrapper</returns>
        ApiResponse<AiPricesWrapper> GetAiPricesWithHttpInfo();
        /// <summary>
        /// Get the checkout setup page URL
        /// </summary>
        /// <remarks>
        /// Hands back the hosted page on which a payment method is attached to the portal's billing account, for the case  where money has to be taken later - a wallet top-up or an automatic one - rather than a plan bought now. A  portal that already has a payment method on file answers with an empty result; a DocSpace administrator may  ask for the page, but once the portal has a billing customer with an e-mail, only its payer may. The call  itself changes nothing and may be repeated: the payment method is stored by the payment provider when the  returned page is completed, after which `GET api/2.0/portal/payment/customerinfo` reports it as set. The URL  is absolute, carries the caller's e-mail, the language of the request and the currency of the region, and  redirects to `successUrl` or `backUrl` when the user finishes or cancels. It buys nothing - a plan is bought  with `PUT api/2.0/portal/payment/url`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">The absolute address the setup page sends the user back to when attaching a payment method is abandoned. It  has to be a well-formed URL and must be reachable by that user rather than by the portal.</param>
        /// <param name="successUrl">The absolute address the setup page sends the user to once the payment provider has stored the payment  method. Reaching it means a method is now on file, which `GET api/2.0/portal/payment/customerinfo` confirms;  nothing has been charged.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-checkout-setup-url/">REST API Reference for GetCheckoutSetupUrl Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper GetCheckoutSetupUrl(string backUrl, string successUrl);

        /// <summary>
        /// Get the checkout setup page URL
        /// </summary>
        /// <remarks>
        /// Hands back the hosted page on which a payment method is attached to the portal's billing account, for the case  where money has to be taken later - a wallet top-up or an automatic one - rather than a plan bought now. A  portal that already has a payment method on file answers with an empty result; a DocSpace administrator may  ask for the page, but once the portal has a billing customer with an e-mail, only its payer may. The call  itself changes nothing and may be repeated: the payment method is stored by the payment provider when the  returned page is completed, after which `GET api/2.0/portal/payment/customerinfo` reports it as set. The URL  is absolute, carries the caller's e-mail, the language of the request and the currency of the region, and  redirects to `successUrl` or `backUrl` when the user finishes or cancels. It buys nothing - a plan is bought  with `PUT api/2.0/portal/payment/url`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">The absolute address the setup page sends the user back to when attaching a payment method is abandoned. It  has to be a well-formed URL and must be reachable by that user rather than by the portal.</param>
        /// <param name="successUrl">The absolute address the setup page sends the user to once the payment provider has stored the payment  method. Reaching it means a method is now on file, which `GET api/2.0/portal/payment/customerinfo` confirms;  nothing has been charged.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-checkout-setup-url/">REST API Reference for GetCheckoutSetupUrl Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> GetCheckoutSetupUrlWithHttpInfo(string backUrl, string successUrl);
        /// <summary>
        /// Get the customer balance
        /// </summary>
        /// <remarks>
        /// Returns the money the portal has in its wallet as the accounting service holds it: the account with its own  currency, one sub-account per currency with the amount on it, and the most recent credit movement. Only a  DocSpace administrator may read it, an installation without a billing service answers 403, and a portal that  has never been a customer gets an empty result. The call is read-only. This balance is what the wallet  services are charged against, so it falls as they are used and rises with  `POST api/2.0/portal/payment/deposit`; the movements behind a change are listed by  `GET api/2.0/portal/payment/customer/operations`. Pass `refresh=true` to re-read it from the accounting  service rather than the cache - right after a top-up the cached figure is still the old one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Whether the answer is fetched from the billing service instead of the portal cache. The cached copy is what a  start-up needs and costs nothing; asking for a fresh one makes a remote call, so use it right after a  purchase or a top-up and not on every read. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-balance/">REST API Reference for GetCustomerBalance Operation</seealso>
        /// <returns>BalanceWrapper</returns>
        BalanceWrapper GetCustomerBalance(bool? refresh = default);

        /// <summary>
        /// Get the customer balance
        /// </summary>
        /// <remarks>
        /// Returns the money the portal has in its wallet as the accounting service holds it: the account with its own  currency, one sub-account per currency with the amount on it, and the most recent credit movement. Only a  DocSpace administrator may read it, an installation without a billing service answers 403, and a portal that  has never been a customer gets an empty result. The call is read-only. This balance is what the wallet  services are charged against, so it falls as they are used and rises with  `POST api/2.0/portal/payment/deposit`; the movements behind a change are listed by  `GET api/2.0/portal/payment/customer/operations`. Pass `refresh=true` to re-read it from the accounting  service rather than the cache - right after a top-up the cached figure is still the old one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Whether the answer is fetched from the billing service instead of the portal cache. The cached copy is what a  start-up needs and costs nothing; asking for a fresh one makes a remote call, so use it right after a  purchase or a top-up and not on every read. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-balance/">REST API Reference for GetCustomerBalance Operation</seealso>
        /// <returns>ApiResponse of BalanceWrapper</returns>
        ApiResponse<BalanceWrapper> GetCustomerBalanceWithHttpInfo(bool? refresh = default);
        /// <summary>
        /// Get the customer information
        /// </summary>
        /// <remarks>
        /// Returns the billing customer behind the portal: the e-mail its billing account is registered to, whether a  payment method is stored for it, and the portal user who is the payer of that account. Only a DocSpace  administrator may read it, and the call is read-only. The answer is empty in two ordinary cases - the  installation has no billing service configured at all, and the portal has never been a customer - so an empty  body is not an error. `payer` is filled in only when the billing e-mail belongs to a portal user; when it does  not, the e-mail is still shown but the field stays empty, and that is what makes every payer-only operation of  this group unreachable for everybody. `refresh=true` re-reads the customer from the billing provider instead  of the cache, which is worth doing right after a payment method has been attached.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Whether the answer is fetched from the billing service instead of the portal cache. The cached copy is what a  start-up needs and costs nothing; asking for a fresh one makes a remote call, so use it right after a  purchase or a top-up and not on every read. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-info/">REST API Reference for GetCustomerInfo Operation</seealso>
        /// <returns>CustomerInfoWrapper</returns>
        CustomerInfoWrapper GetCustomerInfo(bool? refresh = default);

        /// <summary>
        /// Get the customer information
        /// </summary>
        /// <remarks>
        /// Returns the billing customer behind the portal: the e-mail its billing account is registered to, whether a  payment method is stored for it, and the portal user who is the payer of that account. Only a DocSpace  administrator may read it, and the call is read-only. The answer is empty in two ordinary cases - the  installation has no billing service configured at all, and the portal has never been a customer - so an empty  body is not an error. `payer` is filled in only when the billing e-mail belongs to a portal user; when it does  not, the e-mail is still shown but the field stays empty, and that is what makes every payer-only operation of  this group unreachable for everybody. `refresh=true` re-reads the customer from the billing provider instead  of the cache, which is worth doing right after a payment method has been attached.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Whether the answer is fetched from the billing service instead of the portal cache. The cached copy is what a  start-up needs and costs nothing; asking for a fresh one makes a remote call, so use it right after a  purchase or a top-up and not on every read. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-info/">REST API Reference for GetCustomerInfo Operation</seealso>
        /// <returns>ApiResponse of CustomerInfoWrapper</returns>
        ApiResponse<CustomerInfoWrapper> GetCustomerInfoWithHttpInfo(bool? refresh = default);
        /// <summary>
        /// Get the customer monthly usage
        /// </summary>
        /// <remarks>
        /// Returns what the portal spent from its wallet added up per calendar month, so a client can draw a spending  chart without paging through every movement. Only a DocSpace administrator may read it, a portal with no  billing customer answers with an empty result, and the call is read-only. `startDate` and `endDate` bound the  period, both inclusive, and default to the portal creation date and the present moment; the months are cut in  the portal time zone, so a movement at the edge of a month falls where the portal sees it and not where UTC  does. Each item names its year and month, the total charged in it with the currency, and how many operations  that total came from. The movements behind a month are in `GET api/2.0/portal/payment/customer/operations`,  and the same figures as a file come from `POST api/2.0/portal/payment/customer/usage/monthly/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The beginning of the reported period, inclusive. The months are cut in the portal time zone rather than in  UTC, so spending at the turn of a month falls where the portal sees it; defaults to the portal creation date. (optional)</param>
        /// <param name="endDate">The end of the reported period, inclusive. Cut in the portal time zone in the same way as `startDate`, and  defaults to the moment the call is made. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-monthly-usage/">REST API Reference for GetCustomerMonthlyUsage Operation</seealso>
        /// <returns>CustomerMonthlyUsageArrayWrapper</returns>
        CustomerMonthlyUsageArrayWrapper GetCustomerMonthlyUsage(DateTime? startDate = default, DateTime? endDate = default);

        /// <summary>
        /// Get the customer monthly usage
        /// </summary>
        /// <remarks>
        /// Returns what the portal spent from its wallet added up per calendar month, so a client can draw a spending  chart without paging through every movement. Only a DocSpace administrator may read it, a portal with no  billing customer answers with an empty result, and the call is read-only. `startDate` and `endDate` bound the  period, both inclusive, and default to the portal creation date and the present moment; the months are cut in  the portal time zone, so a movement at the edge of a month falls where the portal sees it and not where UTC  does. Each item names its year and month, the total charged in it with the currency, and how many operations  that total came from. The movements behind a month are in `GET api/2.0/portal/payment/customer/operations`,  and the same figures as a file come from `POST api/2.0/portal/payment/customer/usage/monthly/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The beginning of the reported period, inclusive. The months are cut in the portal time zone rather than in  UTC, so spending at the turn of a month falls where the portal sees it; defaults to the portal creation date. (optional)</param>
        /// <param name="endDate">The end of the reported period, inclusive. Cut in the portal time zone in the same way as `startDate`, and  defaults to the moment the call is made. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-monthly-usage/">REST API Reference for GetCustomerMonthlyUsage Operation</seealso>
        /// <returns>ApiResponse of CustomerMonthlyUsageArrayWrapper</returns>
        ApiResponse<CustomerMonthlyUsageArrayWrapper> GetCustomerMonthlyUsageWithHttpInfo(DateTime? startDate = default, DateTime? endDate = default);
        /// <summary>
        /// Get the monthly usage report status
        /// </summary>
        /// <remarks>
        /// Returns the state of the `xlsx` monthly usage report this user started with  `POST api/2.0/portal/payment/customer/usage/monthly/report`: `percentage` while it is being built,  `isCompleted` when it is done, `resultFileId`, `resultFileName` and `resultFileUrl` pointing at the file in  the caller's My documents, and `error` when the build failed. The portal needs a billing customer and the  caller has to be a DocSpace administrator; the call is read-only and is the one to poll. The task is kept per  user and per report kind, so it reports neither another administrator's report nor the operations and service  usage ones, which have their own status operations. An empty result means this user has no monthly usage  report at all - none was started, or the finished one was already picked up or terminated. A completed task is  dropped as soon as the next report is started, so read the file link out of the same answer that first reports  `isCompleted`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-monthly-usage-report/">REST API Reference for GetCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>DocumentBuilderTaskWrapper</returns>
        DocumentBuilderTaskWrapper GetCustomerMonthlyUsageReport();

        /// <summary>
        /// Get the monthly usage report status
        /// </summary>
        /// <remarks>
        /// Returns the state of the `xlsx` monthly usage report this user started with  `POST api/2.0/portal/payment/customer/usage/monthly/report`: `percentage` while it is being built,  `isCompleted` when it is done, `resultFileId`, `resultFileName` and `resultFileUrl` pointing at the file in  the caller's My documents, and `error` when the build failed. The portal needs a billing customer and the  caller has to be a DocSpace administrator; the call is read-only and is the one to poll. The task is kept per  user and per report kind, so it reports neither another administrator's report nor the operations and service  usage ones, which have their own status operations. An empty result means this user has no monthly usage  report at all - none was started, or the finished one was already picked up or terminated. A completed task is  dropped as soon as the next report is started, so read the file link out of the same answer that first reports  `isCompleted`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-monthly-usage-report/">REST API Reference for GetCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>ApiResponse of DocumentBuilderTaskWrapper</returns>
        ApiResponse<DocumentBuilderTaskWrapper> GetCustomerMonthlyUsageReportWithHttpInfo();
        /// <summary>
        /// Get the wallet operations
        /// </summary>
        /// <remarks>
        /// Lists the money movements on the portal's wallet - top-ups, the charges of the wallet services, refunds and  corrections - one page at a time, which is what a billing history is built from. Only a DocSpace administrator  may read it, a portal with no billing customer answers with an empty result, and the call is read-only. Every  filter is optional: `startDate` and `endDate` are read in the portal time zone and default to the portal  creation date and the present moment, `serviceName` narrows to particular wallet services and fails with 404  on a name this installation does not sell, `participantName`, `type` and `status` narrow to who caused a  movement and how it ended, and `credit` and `debit` include or exclude the two directions. `offset` and  `limit` page through the result and default to 0 and 25, `orderBy` and `orderType` sort it, and the answer  repeats them next to `totalQuantity`, `totalPage` and `currentPage` so a client can page without counting. The  same data as a downloadable file is `POST api/2.0/portal/payment/customer/operationsreport`, and the figures  added up per service are `GET api/2.0/portal/payment/customer/usage`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">The number of movements to skip before the first one returned, for walking through a long history page by  page. Counted after the filters and the ordering are applied, and starts at 0 when omitted. (optional)</param>
        /// <param name="limit">The maximum number of movements returned in one page. Defaults to 25 when omitted; the answer echoes the  window back next to `totalQuantity`, `totalPage` and `currentPage`, so the next `offset` can be computed  without counting the items. (optional)</param>
        /// <param name="serviceName">The wallet services whose movements are kept, named the way the billing catalogue names them - `backup`,  `ai-tools`, `ai-search`, `disk-storage`, `docscloud`. Take the values from the `serviceName` field of  `GET api/2.0/portal/payment/walletservices`; the match ignores case, a name this installation does not sell  fails the call with 404, and an omitted list keeps every service. A bare string is accepted in place of an  array for backward compatibility. (optional)</param>
        /// <param name="startDate">The beginning of the reported period, inclusive. Read in the portal time zone rather than in UTC, so a  movement at the edge of the period falls where the portal sees it; defaults to the portal creation date. (optional)</param>
        /// <param name="endDate">The end of the reported period, inclusive. Read in the portal time zone rather than in UTC, and defaults to  the moment the call is made. (optional)</param>
        /// <param name="participantName">The participant whose movements are kept - the account the accounting service records as the cause of a  movement. A movement caused by a portal user carries that user ID here, and one caused by the portal itself  carries the customer name; surrounding whitespace is trimmed, and an omitted value keeps every participant. (optional)</param>
        /// <param name="credit">Whether movements that add money to the wallet - top-ups, refunds and corrections in the portal's favour -  are kept. Both directions are reported when neither this nor `debit` is given. (optional)</param>
        /// <param name="debit">Whether movements that take money out of the wallet - the charges of the wallet services - are kept. Both  directions are reported when neither this nor `credit` is given. (optional)</param>
        /// <param name="type">The kind of movement to keep, which says what caused the money to move rather than how it ended. Every kind  is reported when it is omitted. (optional)</param>
        /// <param name="status">The outcome to keep. A movement that is still being settled is reported as pending and may change later,  while the other outcomes are final; every outcome is reported when this is omitted. (optional)</param>
        /// <param name="orderBy">The name of the field the movements are sorted by, spelled as the accounting service names it, such as  `StartDate` or `ServiceName`. Surrounding whitespace is trimmed, and the accounting service applies its own  ordering when this is omitted. (optional)</param>
        /// <param name="orderType">The direction the field named in `orderBy` is sorted in. Newest or largest first is what the accounting  service does by default, so leaving this out sorts the same way as asking for descending explicitly. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-operations/">REST API Reference for GetCustomerOperations Operation</seealso>
        /// <returns>ReportWrapper</returns>
        ReportWrapper GetCustomerOperations(int? offset = default, int? limit = default, List<string>? serviceName = default, DateTime? startDate = default, DateTime? endDate = default, string? participantName = default, bool? credit = default, bool? debit = default, OperationType? type = default, OperationStatus? status = default, string? orderBy = default, OperationOrderType? orderType = default);

        /// <summary>
        /// Get the wallet operations
        /// </summary>
        /// <remarks>
        /// Lists the money movements on the portal's wallet - top-ups, the charges of the wallet services, refunds and  corrections - one page at a time, which is what a billing history is built from. Only a DocSpace administrator  may read it, a portal with no billing customer answers with an empty result, and the call is read-only. Every  filter is optional: `startDate` and `endDate` are read in the portal time zone and default to the portal  creation date and the present moment, `serviceName` narrows to particular wallet services and fails with 404  on a name this installation does not sell, `participantName`, `type` and `status` narrow to who caused a  movement and how it ended, and `credit` and `debit` include or exclude the two directions. `offset` and  `limit` page through the result and default to 0 and 25, `orderBy` and `orderType` sort it, and the answer  repeats them next to `totalQuantity`, `totalPage` and `currentPage` so a client can page without counting. The  same data as a downloadable file is `POST api/2.0/portal/payment/customer/operationsreport`, and the figures  added up per service are `GET api/2.0/portal/payment/customer/usage`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">The number of movements to skip before the first one returned, for walking through a long history page by  page. Counted after the filters and the ordering are applied, and starts at 0 when omitted. (optional)</param>
        /// <param name="limit">The maximum number of movements returned in one page. Defaults to 25 when omitted; the answer echoes the  window back next to `totalQuantity`, `totalPage` and `currentPage`, so the next `offset` can be computed  without counting the items. (optional)</param>
        /// <param name="serviceName">The wallet services whose movements are kept, named the way the billing catalogue names them - `backup`,  `ai-tools`, `ai-search`, `disk-storage`, `docscloud`. Take the values from the `serviceName` field of  `GET api/2.0/portal/payment/walletservices`; the match ignores case, a name this installation does not sell  fails the call with 404, and an omitted list keeps every service. A bare string is accepted in place of an  array for backward compatibility. (optional)</param>
        /// <param name="startDate">The beginning of the reported period, inclusive. Read in the portal time zone rather than in UTC, so a  movement at the edge of the period falls where the portal sees it; defaults to the portal creation date. (optional)</param>
        /// <param name="endDate">The end of the reported period, inclusive. Read in the portal time zone rather than in UTC, and defaults to  the moment the call is made. (optional)</param>
        /// <param name="participantName">The participant whose movements are kept - the account the accounting service records as the cause of a  movement. A movement caused by a portal user carries that user ID here, and one caused by the portal itself  carries the customer name; surrounding whitespace is trimmed, and an omitted value keeps every participant. (optional)</param>
        /// <param name="credit">Whether movements that add money to the wallet - top-ups, refunds and corrections in the portal's favour -  are kept. Both directions are reported when neither this nor `debit` is given. (optional)</param>
        /// <param name="debit">Whether movements that take money out of the wallet - the charges of the wallet services - are kept. Both  directions are reported when neither this nor `credit` is given. (optional)</param>
        /// <param name="type">The kind of movement to keep, which says what caused the money to move rather than how it ended. Every kind  is reported when it is omitted. (optional)</param>
        /// <param name="status">The outcome to keep. A movement that is still being settled is reported as pending and may change later,  while the other outcomes are final; every outcome is reported when this is omitted. (optional)</param>
        /// <param name="orderBy">The name of the field the movements are sorted by, spelled as the accounting service names it, such as  `StartDate` or `ServiceName`. Surrounding whitespace is trimmed, and the accounting service applies its own  ordering when this is omitted. (optional)</param>
        /// <param name="orderType">The direction the field named in `orderBy` is sorted in. Newest or largest first is what the accounting  service does by default, so leaving this out sorts the same way as asking for descending explicitly. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-operations/">REST API Reference for GetCustomerOperations Operation</seealso>
        /// <returns>ApiResponse of ReportWrapper</returns>
        ApiResponse<ReportWrapper> GetCustomerOperationsWithHttpInfo(int? offset = default, int? limit = default, List<string>? serviceName = default, DateTime? startDate = default, DateTime? endDate = default, string? participantName = default, bool? credit = default, bool? debit = default, OperationType? type = default, OperationStatus? status = default, string? orderBy = default, OperationOrderType? orderType = default);
        /// <summary>
        /// Get the operations report status
        /// </summary>
        /// <remarks>
        /// Returns the state of the `xlsx` wallet operations report this user started with  `POST api/2.0/portal/payment/customer/operationsreport`: `percentage` while it is being built, `isCompleted`  when it is done, `resultFileId`, `resultFileName` and `resultFileUrl` pointing at the file in the caller's My  documents, and `error` when the build failed. The portal needs a billing customer and the caller has to be a  DocSpace administrator; the call is read-only and is the one to poll. The task is kept per user and per report  kind, so it never reports another administrator's report, nor the service usage and monthly usage ones, which  have their own status operations. An empty result means this user has no operations report at all - none was  started, or the finished one was already picked up or terminated. A completed task is dropped as soon as the  next report is started, so read the file link out of the same answer that first reports `isCompleted`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-operations-report/">REST API Reference for GetCustomerOperationsReport Operation</seealso>
        /// <returns>DocumentBuilderTaskWrapper</returns>
        DocumentBuilderTaskWrapper GetCustomerOperationsReport();

        /// <summary>
        /// Get the operations report status
        /// </summary>
        /// <remarks>
        /// Returns the state of the `xlsx` wallet operations report this user started with  `POST api/2.0/portal/payment/customer/operationsreport`: `percentage` while it is being built, `isCompleted`  when it is done, `resultFileId`, `resultFileName` and `resultFileUrl` pointing at the file in the caller's My  documents, and `error` when the build failed. The portal needs a billing customer and the caller has to be a  DocSpace administrator; the call is read-only and is the one to poll. The task is kept per user and per report  kind, so it never reports another administrator's report, nor the service usage and monthly usage ones, which  have their own status operations. An empty result means this user has no operations report at all - none was  started, or the finished one was already picked up or terminated. A completed task is dropped as soon as the  next report is started, so read the file link out of the same answer that first reports `isCompleted`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-operations-report/">REST API Reference for GetCustomerOperationsReport Operation</seealso>
        /// <returns>ApiResponse of DocumentBuilderTaskWrapper</returns>
        ApiResponse<DocumentBuilderTaskWrapper> GetCustomerOperationsReportWithHttpInfo();
        /// <summary>
        /// Get the customer service usage
        /// </summary>
        /// <remarks>
        /// Returns how much of each wallet service the portal consumed and what that cost, added up per service instead  of listed per movement. Only a DocSpace administrator may read it, a portal with no billing customer answers  with an empty result, and the call is read-only. The filters are optional: `serviceName` narrows to particular  services and fails with 404 on a name this installation does not sell, `participantName` and `status` narrow  to who consumed and how the operation ended, `startDate` and `endDate` bound the period in the portal time  zone, `metadata` matches the key and value pairs a service records with its usage, and `offset`, `limit`,  `orderBy` and `orderType` page and sort the result. Amounts come with the unit the service is sold in, except  AI tools, whose consumption is reported in tokens rather than in AI credits. The individual charges behind  these totals are `GET api/2.0/portal/payment/customer/operations`, and the same figures as a downloadable file  are `POST api/2.0/portal/payment/customer/usage/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName">The wallet services whose consumption is added up, named the way the billing catalogue names them -  `backup`, `ai-tools`, `ai-search`, `disk-storage`, `docscloud`. Take the values from the `serviceName` field  of `GET api/2.0/portal/payment/walletservices`; the match ignores case, a name this installation does not  sell fails the call with 404, and an omitted list covers every service. (optional)</param>
        /// <param name="participantName">The participant whose consumption is added up - the account the accounting service records as the consumer.  Consumption caused by a portal user carries that user ID here; surrounding whitespace is trimmed, and an  omitted value covers every participant. (optional)</param>
        /// <param name="status">The outcome to keep. Consumption that is still being settled is reported as pending and may change later,  while the other outcomes are final; every outcome is counted when this is omitted. (optional)</param>
        /// <param name="startDate">The beginning of the reported period, inclusive. Read in the portal time zone rather than in UTC, and  defaults to the portal creation date. (optional)</param>
        /// <param name="endDate">The end of the reported period, inclusive. Read in the portal time zone rather than in UTC, and defaults to  the moment the call is made. (optional)</param>
        /// <param name="metadata">The usage annotations a wallet service records alongside its consumption, as the key and value pairs that  must all match for a record to be counted. The keys are chosen by the service that writes them, so read them  off the `metadata` of the records already returned rather than guessing; an omitted map counts every record. (optional)</param>
        /// <param name="offset">The number of per-service totals to skip before the first one returned. Counted after the filters and the  ordering are applied, and starts at 0 when omitted. (optional)</param>
        /// <param name="limit">The maximum number of per-service totals returned in one page. Defaults to 25 when omitted; the answer echoes  the window back with its paging information, so the next `offset` can be computed without counting the items. (optional)</param>
        /// <param name="orderBy">The name of the field the per-service totals are sorted by, spelled as the accounting service names it, such  as `ServiceName` or `StartDate`. Surrounding whitespace is trimmed, and the accounting service applies its  own ordering when this is omitted. (optional)</param>
        /// <param name="orderType">The direction the field named in `orderBy` is sorted in. Newest or largest first is what the accounting  service does by default, so leaving this out sorts the same way as asking for descending explicitly. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-service-usage/">REST API Reference for GetCustomerServiceUsage Operation</seealso>
        /// <returns>CustomerServiceUsageReportWrapper</returns>
        CustomerServiceUsageReportWrapper GetCustomerServiceUsage(List<string>? serviceName = default, string? participantName = default, OperationStatus? status = default, DateTime? startDate = default, DateTime? endDate = default, Dictionary<string, string>? metadata = default, int? offset = default, int? limit = default, string? orderBy = default, OperationOrderType? orderType = default);

        /// <summary>
        /// Get the customer service usage
        /// </summary>
        /// <remarks>
        /// Returns how much of each wallet service the portal consumed and what that cost, added up per service instead  of listed per movement. Only a DocSpace administrator may read it, a portal with no billing customer answers  with an empty result, and the call is read-only. The filters are optional: `serviceName` narrows to particular  services and fails with 404 on a name this installation does not sell, `participantName` and `status` narrow  to who consumed and how the operation ended, `startDate` and `endDate` bound the period in the portal time  zone, `metadata` matches the key and value pairs a service records with its usage, and `offset`, `limit`,  `orderBy` and `orderType` page and sort the result. Amounts come with the unit the service is sold in, except  AI tools, whose consumption is reported in tokens rather than in AI credits. The individual charges behind  these totals are `GET api/2.0/portal/payment/customer/operations`, and the same figures as a downloadable file  are `POST api/2.0/portal/payment/customer/usage/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName">The wallet services whose consumption is added up, named the way the billing catalogue names them -  `backup`, `ai-tools`, `ai-search`, `disk-storage`, `docscloud`. Take the values from the `serviceName` field  of `GET api/2.0/portal/payment/walletservices`; the match ignores case, a name this installation does not  sell fails the call with 404, and an omitted list covers every service. (optional)</param>
        /// <param name="participantName">The participant whose consumption is added up - the account the accounting service records as the consumer.  Consumption caused by a portal user carries that user ID here; surrounding whitespace is trimmed, and an  omitted value covers every participant. (optional)</param>
        /// <param name="status">The outcome to keep. Consumption that is still being settled is reported as pending and may change later,  while the other outcomes are final; every outcome is counted when this is omitted. (optional)</param>
        /// <param name="startDate">The beginning of the reported period, inclusive. Read in the portal time zone rather than in UTC, and  defaults to the portal creation date. (optional)</param>
        /// <param name="endDate">The end of the reported period, inclusive. Read in the portal time zone rather than in UTC, and defaults to  the moment the call is made. (optional)</param>
        /// <param name="metadata">The usage annotations a wallet service records alongside its consumption, as the key and value pairs that  must all match for a record to be counted. The keys are chosen by the service that writes them, so read them  off the `metadata` of the records already returned rather than guessing; an omitted map counts every record. (optional)</param>
        /// <param name="offset">The number of per-service totals to skip before the first one returned. Counted after the filters and the  ordering are applied, and starts at 0 when omitted. (optional)</param>
        /// <param name="limit">The maximum number of per-service totals returned in one page. Defaults to 25 when omitted; the answer echoes  the window back with its paging information, so the next `offset` can be computed without counting the items. (optional)</param>
        /// <param name="orderBy">The name of the field the per-service totals are sorted by, spelled as the accounting service names it, such  as `ServiceName` or `StartDate`. Surrounding whitespace is trimmed, and the accounting service applies its  own ordering when this is omitted. (optional)</param>
        /// <param name="orderType">The direction the field named in `orderBy` is sorted in. Newest or largest first is what the accounting  service does by default, so leaving this out sorts the same way as asking for descending explicitly. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-service-usage/">REST API Reference for GetCustomerServiceUsage Operation</seealso>
        /// <returns>ApiResponse of CustomerServiceUsageReportWrapper</returns>
        ApiResponse<CustomerServiceUsageReportWrapper> GetCustomerServiceUsageWithHttpInfo(List<string>? serviceName = default, string? participantName = default, OperationStatus? status = default, DateTime? startDate = default, DateTime? endDate = default, Dictionary<string, string>? metadata = default, int? offset = default, int? limit = default, string? orderBy = default, OperationOrderType? orderType = default);
        /// <summary>
        /// Get the service usage report status
        /// </summary>
        /// <remarks>
        /// Returns the state of the `xlsx` service usage report this user started with  `POST api/2.0/portal/payment/customer/usage/report`: `percentage` while it is being built, `isCompleted` when  it is done, `resultFileId`, `resultFileName` and `resultFileUrl` pointing at the file in the caller's My  documents, and `error` when the build failed. The portal needs a billing customer and the caller has to be a  DocSpace administrator; the call is read-only and is the one to poll. The task is kept per user and per report  kind, so it reports neither another administrator's report nor the operations and monthly usage ones, which  have their own status operations. An empty result means this user has no service usage report at all - none  was started, or the finished one was already picked up or terminated. A completed task is dropped as soon as  the next report is started, so read the file link out of the same answer that first reports `isCompleted`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-service-usage-report/">REST API Reference for GetCustomerServiceUsageReport Operation</seealso>
        /// <returns>DocumentBuilderTaskWrapper</returns>
        DocumentBuilderTaskWrapper GetCustomerServiceUsageReport();

        /// <summary>
        /// Get the service usage report status
        /// </summary>
        /// <remarks>
        /// Returns the state of the `xlsx` service usage report this user started with  `POST api/2.0/portal/payment/customer/usage/report`: `percentage` while it is being built, `isCompleted` when  it is done, `resultFileId`, `resultFileName` and `resultFileUrl` pointing at the file in the caller's My  documents, and `error` when the build failed. The portal needs a billing customer and the caller has to be a  DocSpace administrator; the call is read-only and is the one to poll. The task is kept per user and per report  kind, so it reports neither another administrator's report nor the operations and monthly usage ones, which  have their own status operations. An empty result means this user has no service usage report at all - none  was started, or the finished one was already picked up or terminated. A completed task is dropped as soon as  the next report is started, so read the file link out of the same answer that first reports `isCompleted`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-service-usage-report/">REST API Reference for GetCustomerServiceUsageReport Operation</seealso>
        /// <returns>ApiResponse of DocumentBuilderTaskWrapper</returns>
        ApiResponse<DocumentBuilderTaskWrapper> GetCustomerServiceUsageReportWithHttpInfo();
        /// <summary>
        /// Get the billing account page
        /// </summary>
        /// <remarks>
        /// Hands back the address of the portal page on which the billing account is managed - the payment method on  file, the invoices and the receipts - so a client can link to it instead of assembling the address itself. The  portal must already have a billing customer: one that has never had it gets an empty result, and an  installation without a billing service answers 403. Only the payer or the portal owner may read it, and the  call changes nothing. The value is relative to the portal root (`payment.ashx`), and the optional `backUrl` is  appended to it as a query parameter so the page can send the user back where they came from. It is not a  checkout page: a plan is bought with `PUT api/2.0/portal/payment/url` and a payment method is attached with  `GET api/2.0/portal/payment/checkoutsetupurl`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">The absolute address the billing account page should offer as its way back. It is appended to the returned  portal-relative address as a query parameter rather than followed here, and omitting it yields the bare  address of the page. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-account/">REST API Reference for GetPaymentAccount Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper GetPaymentAccount(string? backUrl = default);

        /// <summary>
        /// Get the billing account page
        /// </summary>
        /// <remarks>
        /// Hands back the address of the portal page on which the billing account is managed - the payment method on  file, the invoices and the receipts - so a client can link to it instead of assembling the address itself. The  portal must already have a billing customer: one that has never had it gets an empty result, and an  installation without a billing service answers 403. Only the payer or the portal owner may read it, and the  call changes nothing. The value is relative to the portal root (`payment.ashx`), and the optional `backUrl` is  appended to it as a query parameter so the page can send the user back where they came from. It is not a  checkout page: a plan is bought with `PUT api/2.0/portal/payment/url` and a payment method is attached with  `GET api/2.0/portal/payment/checkoutsetupurl`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">The absolute address the billing account page should offer as its way back. It is appended to the returned  portal-relative address as a query parameter rather than followed here, and omitting it yields the bare  address of the page. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-account/">REST API Reference for GetPaymentAccount Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> GetPaymentAccountWithHttpInfo(string? backUrl = default);
        /// <summary>
        /// Get the billing currencies
        /// </summary>
        /// <remarks>
        /// Tells a client which currency the portal is billed in: the default currency of the portal region always comes  first, followed by the currency resolved for the current request when that one differs, so the answer holds  one or two items. Nothing has to be called first, the caller needs the permission to edit the portal settings,  and the call is read-only. Each item carries the country code of the region, the currency symbol and the  native name of the currency; the first item is the currency the amounts from  `GET api/2.0/portal/payment/prices` are expressed in. These are the currencies of the subscription prices, and  they are not the accounting currencies the wallet is topped up in - those come with the balance in  `GET api/2.0/portal/payment/customer/balance`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-currencies/">REST API Reference for GetPaymentCurrencies Operation</seealso>
        /// <returns>CurrenciesArrayWrapper</returns>
        CurrenciesArrayWrapper GetPaymentCurrencies();

        /// <summary>
        /// Get the billing currencies
        /// </summary>
        /// <remarks>
        /// Tells a client which currency the portal is billed in: the default currency of the portal region always comes  first, followed by the currency resolved for the current request when that one differs, so the answer holds  one or two items. Nothing has to be called first, the caller needs the permission to edit the portal settings,  and the call is read-only. Each item carries the country code of the region, the currency symbol and the  native name of the currency; the first item is the currency the amounts from  `GET api/2.0/portal/payment/prices` are expressed in. These are the currencies of the subscription prices, and  they are not the accounting currencies the wallet is topped up in - those come with the balance in  `GET api/2.0/portal/payment/customer/balance`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-currencies/">REST API Reference for GetPaymentCurrencies Operation</seealso>
        /// <returns>ApiResponse of CurrenciesArrayWrapper</returns>
        ApiResponse<CurrenciesArrayWrapper> GetPaymentCurrenciesWithHttpInfo();
        /// <summary>
        /// Get the purchasable quotas
        /// </summary>
        /// <remarks>
        /// Lists the quotas the portal can be put on - the paid plans and the wallet services - each with its price, its  features and the limits it grants, which is what a pricing page is built from. Nothing has to be called first,  the caller needs the permission to edit the portal settings, and the call is read-only. Only quotas marked  visible are listed, newest first, and the two optional filters narrow that: `wallet` selects the wallet  services (`true`) or the subscription plans (`false`), `additional` selects the add-ons to a plan (`true`) or  the plans themselves (`false`), and an omitted filter keeps both kinds. A portal on a non-profit quota is a  special case - asking for `additional=false` returns that single quota and nothing else, because no other plan  may be bought for it. The quota the portal is actually on is not marked here; read it from  `GET api/2.0/portal/payment/quota`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wallet">Which side of the catalogue is listed: `true` keeps the services paid out of the portal wallet, `false` keeps  the subscription plans, and omitting it keeps both. (optional)</param>
        /// <param name="additional">Which layer of the catalogue is listed: `true` keeps the add-ons that extend a plan, `false` keeps the plans  themselves, and omitting it keeps both. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-quotas/">REST API Reference for GetPaymentQuotas Operation</seealso>
        /// <returns>QuotaArrayWrapper</returns>
        QuotaArrayWrapper GetPaymentQuotas(bool? wallet = default, bool? additional = default);

        /// <summary>
        /// Get the purchasable quotas
        /// </summary>
        /// <remarks>
        /// Lists the quotas the portal can be put on - the paid plans and the wallet services - each with its price, its  features and the limits it grants, which is what a pricing page is built from. Nothing has to be called first,  the caller needs the permission to edit the portal settings, and the call is read-only. Only quotas marked  visible are listed, newest first, and the two optional filters narrow that: `wallet` selects the wallet  services (`true`) or the subscription plans (`false`), `additional` selects the add-ons to a plan (`true`) or  the plans themselves (`false`), and an omitted filter keeps both kinds. A portal on a non-profit quota is a  special case - asking for `additional=false` returns that single quota and nothing else, because no other plan  may be bought for it. The quota the portal is actually on is not marked here; read it from  `GET api/2.0/portal/payment/quota`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wallet">Which side of the catalogue is listed: `true` keeps the services paid out of the portal wallet, `false` keeps  the subscription plans, and omitting it keeps both. (optional)</param>
        /// <param name="additional">Which layer of the catalogue is listed: `true` keeps the add-ons that extend a plan, `false` keeps the plans  themselves, and omitting it keeps both. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-quotas/">REST API Reference for GetPaymentQuotas Operation</seealso>
        /// <returns>ApiResponse of QuotaArrayWrapper</returns>
        ApiResponse<QuotaArrayWrapper> GetPaymentQuotasWithHttpInfo(bool? wallet = default, bool? additional = default);
        /// <summary>
        /// Get the payment page URL
        /// </summary>
        /// <remarks>
        /// Starts the purchase of a monthly paid plan for this portal by handing back the hosted checkout page the buyer  has to open; nothing is bought until that page is completed. The portal must have no paid plan yet - a portal  whose plan is already paid gets an empty result and changes its subscription through  `PUT api/2.0/portal/payment/update` instead - and the product name in `quantity` must be one of the monthly,  non-wallet plans listed by `GET api/2.0/portal/payment/quotas`. Only a DocSpace administrator may call it. The  call itself changes nothing on the portal and may be repeated: the money is taken by the payment provider on  the checkout page, and the plan becomes active once the provider confirms it. The returned URL is absolute and  single-purpose - it carries the caller's e-mail, the language of the request and the currency of the request  region, and it redirects to `successUrl` or `backUrl` when the buyer finishes or cancels. Exactly one product  per call is accepted and its quantity has to be greater than zero; yearly and wallet products are refused, and  wallet services are bought with `PUT api/2.0/portal/payment/updatewallet` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentUrlRequestDto">The plan being bought and the two pages the hosted checkout returns the buyer to. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-url/">REST API Reference for GetPaymentUrl Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper GetPaymentUrl(PaymentUrlRequestDto? paymentUrlRequestDto = default);

        /// <summary>
        /// Get the payment page URL
        /// </summary>
        /// <remarks>
        /// Starts the purchase of a monthly paid plan for this portal by handing back the hosted checkout page the buyer  has to open; nothing is bought until that page is completed. The portal must have no paid plan yet - a portal  whose plan is already paid gets an empty result and changes its subscription through  `PUT api/2.0/portal/payment/update` instead - and the product name in `quantity` must be one of the monthly,  non-wallet plans listed by `GET api/2.0/portal/payment/quotas`. Only a DocSpace administrator may call it. The  call itself changes nothing on the portal and may be repeated: the money is taken by the payment provider on  the checkout page, and the plan becomes active once the provider confirms it. The returned URL is absolute and  single-purpose - it carries the caller's e-mail, the language of the request and the currency of the request  region, and it redirects to `successUrl` or `backUrl` when the buyer finishes or cancels. Exactly one product  per call is accepted and its quantity has to be greater than zero; yearly and wallet products are refused, and  wallet services are bought with `PUT api/2.0/portal/payment/updatewallet` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentUrlRequestDto">The plan being bought and the two pages the hosted checkout returns the buyer to. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-url/">REST API Reference for GetPaymentUrl Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> GetPaymentUrlWithHttpInfo(PaymentUrlRequestDto? paymentUrlRequestDto = default);
        /// <summary>
        /// Get the product prices
        /// </summary>
        /// <remarks>
        /// Lists what one unit of every purchasable product costs, keyed by the product name that `quantity` takes in the  purchase operations, so a client can price a plan or a wallet service without reading the whole quota list.  Nothing has to be called first, and the caller needs the permission to edit the portal settings, which portal  administrators and the owner have. The call is read-only. Prices are given in the one currency resolved for  this request from the portal region, which `GET api/2.0/portal/payment/currencies` reports; a product with no  price in that currency comes back as `0` rather than being left out, so a zero means unpriced and not free.  The list covers the products on offer, not the portal's own plan - the plan in force, with its limits and its  usage, is `GET api/2.0/portal/payment/quota`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-prices/">REST API Reference for GetPortalPrices Operation</seealso>
        /// <returns>GetPortalPrices200Response</returns>
        GetPortalPrices200Response GetPortalPrices();

        /// <summary>
        /// Get the product prices
        /// </summary>
        /// <remarks>
        /// Lists what one unit of every purchasable product costs, keyed by the product name that `quantity` takes in the  purchase operations, so a client can price a plan or a wallet service without reading the whole quota list.  Nothing has to be called first, and the caller needs the permission to edit the portal settings, which portal  administrators and the owner have. The call is read-only. Prices are given in the one currency resolved for  this request from the portal region, which `GET api/2.0/portal/payment/currencies` reports; a product with no  price in that currency comes back as `0` rather than being left out, so a zero means unpriced and not free.  The list covers the products on offer, not the portal's own plan - the plan in force, with its limits and its  usage, is `GET api/2.0/portal/payment/quota`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-prices/">REST API Reference for GetPortalPrices Operation</seealso>
        /// <returns>ApiResponse of GetPortalPrices200Response</returns>
        ApiResponse<GetPortalPrices200Response> GetPortalPricesWithHttpInfo();
        /// <summary>
        /// Get the current plan and limits
        /// </summary>
        /// <remarks>
        /// Returns the quota the portal is on right now - its paid plan or the free one - with everything a client needs  to render itself: the price, the features that are switched on, the limits they grant (rooms, storage in  bytes, users, administrators, AI) and how much of each is already used. Every signed-in member of the portal  reads it, so it is not restricted to administrators; only guests are refused with 403. The call is read-only.  The plan is served from the cache by default, which is what a start-up needs; `refresh=true` fetches it from  the billing service instead, so use that right after a purchase and not routinely, because it is a remote  call. The catalogue of the quotas that could be bought instead is `GET api/2.0/portal/payment/quotas`, and the  money side of the same portal - customer, wallet and balance - starts at  `GET api/2.0/portal/payment/customerinfo`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Whether the answer is fetched from the billing service instead of the portal cache. The cached copy is what a  start-up needs and costs nothing; asking for a fresh one makes a remote call, so use it right after a  purchase or a top-up and not on every read. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-quota-payment-information/">REST API Reference for GetQuotaPaymentInformation Operation</seealso>
        /// <returns>QuotaWrapper</returns>
        QuotaWrapper GetQuotaPaymentInformation(bool? refresh = default);

        /// <summary>
        /// Get the current plan and limits
        /// </summary>
        /// <remarks>
        /// Returns the quota the portal is on right now - its paid plan or the free one - with everything a client needs  to render itself: the price, the features that are switched on, the limits they grant (rooms, storage in  bytes, users, administrators, AI) and how much of each is already used. Every signed-in member of the portal  reads it, so it is not restricted to administrators; only guests are refused with 403. The call is read-only.  The plan is served from the cache by default, which is what a start-up needs; `refresh=true` fetches it from  the billing service instead, so use that right after a purchase and not routinely, because it is a remote  call. The catalogue of the quotas that could be bought instead is `GET api/2.0/portal/payment/quotas`, and the  money side of the same portal - customer, wallet and balance - starts at  `GET api/2.0/portal/payment/customerinfo`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Whether the answer is fetched from the billing service instead of the portal cache. The cached copy is what a  start-up needs and costs nothing; asking for a fresh one makes a remote call, so use it right after a  purchase or a top-up and not on every read. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-quota-payment-information/">REST API Reference for GetQuotaPaymentInformation Operation</seealso>
        /// <returns>ApiResponse of QuotaWrapper</returns>
        ApiResponse<QuotaWrapper> GetQuotaPaymentInformationWithHttpInfo(bool? refresh = default);
        /// <summary>
        /// Get restricted AI models
        /// </summary>
        /// <remarks>
        /// Returns the AI chat models that are barred on this portal - the ones no user of it may pick for a  conversation, whatever the price list offers. Only a DocSpace administrator may read it, and the call is  read-only. When the installation has no billing service or AI is not enabled for the portal, the answer is an  empty set instead of an error, which is indistinguishable from a portal that restricts nothing. An empty  `models` therefore means every model in `GET api/2.0/portal/payment/ai-prices` may be used. The set names the  barred models and not the allowed ones; replace it with `PUT api/2.0/portal/payment/ai-model/restrictions`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-restricted-ai-models/">REST API Reference for GetRestrictedAiModels Operation</seealso>
        /// <returns>RestrictedModelsResponseWrapper</returns>
        RestrictedModelsResponseWrapper GetRestrictedAiModels();

        /// <summary>
        /// Get restricted AI models
        /// </summary>
        /// <remarks>
        /// Returns the AI chat models that are barred on this portal - the ones no user of it may pick for a  conversation, whatever the price list offers. Only a DocSpace administrator may read it, and the call is  read-only. When the installation has no billing service or AI is not enabled for the portal, the answer is an  empty set instead of an error, which is indistinguishable from a portal that restricts nothing. An empty  `models` therefore means every model in `GET api/2.0/portal/payment/ai-prices` may be used. The set names the  barred models and not the allowed ones; replace it with `PUT api/2.0/portal/payment/ai-model/restrictions`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-restricted-ai-models/">REST API Reference for GetRestrictedAiModels Operation</seealso>
        /// <returns>ApiResponse of RestrictedModelsResponseWrapper</returns>
        ApiResponse<RestrictedModelsResponseWrapper> GetRestrictedAiModelsWithHttpInfo();
        /// <summary>
        /// Get the subscription balance information
        /// </summary>
        /// <remarks>
        /// Reports in money how much of the portal's paid subscription period is still unused - the credit that  `POST api/2.0/portal/payment/subscription/movetowallet` would carry over to the wallet if the subscription  were ended now. The portal must have a billing customer and a plan in the paid state; a plan that is not paid  answers 402, and a paid plan without a subscription row gives 404. Only the payer - the portal user whose  e-mail is the billing customer's e-mail - may read it, and the call is read-only. The answer states the total  cost of the current period with its currency, the start and the end of that period in UTC, the moment the  unused part is measured up to, the days already elapsed, and the remaining balance both in the subscription  currency and converted to the wallet currency. Every figure is computed for the instant of the request, so it  changes between calls.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-subscription-balance-info/">REST API Reference for GetSubscriptionBalanceInfo Operation</seealso>
        /// <returns>SubscriptionBalanceInfoWrapper</returns>
        SubscriptionBalanceInfoWrapper GetSubscriptionBalanceInfo();

        /// <summary>
        /// Get the subscription balance information
        /// </summary>
        /// <remarks>
        /// Reports in money how much of the portal's paid subscription period is still unused - the credit that  `POST api/2.0/portal/payment/subscription/movetowallet` would carry over to the wallet if the subscription  were ended now. The portal must have a billing customer and a plan in the paid state; a plan that is not paid  answers 402, and a paid plan without a subscription row gives 404. Only the payer - the portal user whose  e-mail is the billing customer's e-mail - may read it, and the call is read-only. The answer states the total  cost of the current period with its currency, the start and the end of that period in UTC, the moment the  unused part is measured up to, the days already elapsed, and the remaining balance both in the subscription  currency and converted to the wallet currency. Every figure is computed for the instant of the request, so it  changes between calls.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-subscription-balance-info/">REST API Reference for GetSubscriptionBalanceInfo Operation</seealso>
        /// <returns>ApiResponse of SubscriptionBalanceInfoWrapper</returns>
        ApiResponse<SubscriptionBalanceInfoWrapper> GetSubscriptionBalanceInfoWithHttpInfo();
        /// <summary>
        /// Get the wallet service settings
        /// </summary>
        /// <remarks>
        /// Returns which wallet services an administrator has switched on for this portal by hand, as opposed to the ones  its plan pays for. Only a DocSpace administrator may read it, an installation without a billing service  answers 403, no billing customer is needed, and the call is read-only. `enabledServices` holds the names of  those services and is empty when none was switched on. This is the stored setting and not the state of the  portal: a service the plan brings with it is active without appearing here, so the honest answer to what is  running is `GET api/2.0/portal/payment/activeservices`. One entry is changed with  `POST api/2.0/portal/payment/servicestate`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-wallet-service-settings/">REST API Reference for GetTenantWalletServiceSettings Operation</seealso>
        /// <returns>TenantWalletServiceSettingsWrapper</returns>
        TenantWalletServiceSettingsWrapper GetTenantWalletServiceSettings();

        /// <summary>
        /// Get the wallet service settings
        /// </summary>
        /// <remarks>
        /// Returns which wallet services an administrator has switched on for this portal by hand, as opposed to the ones  its plan pays for. Only a DocSpace administrator may read it, an installation without a billing service  answers 403, no billing customer is needed, and the call is read-only. `enabledServices` holds the names of  those services and is empty when none was switched on. This is the stored setting and not the state of the  portal: a service the plan brings with it is active without appearing here, so the honest answer to what is  running is `GET api/2.0/portal/payment/activeservices`. One entry is changed with  `POST api/2.0/portal/payment/servicestate`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-wallet-service-settings/">REST API Reference for GetTenantWalletServiceSettings Operation</seealso>
        /// <returns>ApiResponse of TenantWalletServiceSettingsWrapper</returns>
        ApiResponse<TenantWalletServiceSettingsWrapper> GetTenantWalletServiceSettingsWithHttpInfo();
        /// <summary>
        /// Get the auto top-up settings
        /// </summary>
        /// <remarks>
        /// Returns the portal's automatic wallet top-up settings - whether it is on, the balance that triggers a  charge, the balance it is topped up to, and the currency both are expressed in. Any DocSpace  administrator may read them, and unlike the operation that changes them this one needs neither a  billing customer nor a configured billing service, so it answers on a portal that has never paid for  anything. It is read-only and changes nothing.  A portal that has never configured top-up gets the defaults rather than an empty result: `enabled` is  false, `currency` is null, and `minBalance` and `upToBalance` are 0. Those two zeros are outside the  ranges `POST api/2.0/portal/payment/topupsettings` accepts - 5 to 1000 and 6 to 5000 - so the answer  cannot be sent straight back to it; supply real values instead. `lastModified` is  `0001-01-01T00:00:00` until the settings are stored for the first time.  `lowBalanceThreshold` and `lowBalanceNotified` are maintained by the portal itself: they are reported  here, but ignored when the settings are written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-wallet-settings/">REST API Reference for GetTenantWalletSettings Operation</seealso>
        /// <returns>TenantWalletSettingsResponseWrapper</returns>
        TenantWalletSettingsResponseWrapper GetTenantWalletSettings();

        /// <summary>
        /// Get the auto top-up settings
        /// </summary>
        /// <remarks>
        /// Returns the portal's automatic wallet top-up settings - whether it is on, the balance that triggers a  charge, the balance it is topped up to, and the currency both are expressed in. Any DocSpace  administrator may read them, and unlike the operation that changes them this one needs neither a  billing customer nor a configured billing service, so it answers on a portal that has never paid for  anything. It is read-only and changes nothing.  A portal that has never configured top-up gets the defaults rather than an empty result: `enabled` is  false, `currency` is null, and `minBalance` and `upToBalance` are 0. Those two zeros are outside the  ranges `POST api/2.0/portal/payment/topupsettings` accepts - 5 to 1000 and 6 to 5000 - so the answer  cannot be sent straight back to it; supply real values instead. `lastModified` is  `0001-01-01T00:00:00` until the settings are stored for the first time.  `lowBalanceThreshold` and `lowBalanceNotified` are maintained by the portal itself: they are reported  here, but ignored when the settings are written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-wallet-settings/">REST API Reference for GetTenantWalletSettings Operation</seealso>
        /// <returns>ApiResponse of TenantWalletSettingsResponseWrapper</returns>
        ApiResponse<TenantWalletSettingsResponseWrapper> GetTenantWalletSettingsWithHttpInfo();
        /// <summary>
        /// Get a wallet service
        /// </summary>
        /// <remarks>
        /// Returns one wallet service by name, for a client that already knows which service it needs and does not want  the whole catalogue. `service` is the name of the service - `Storage`, `Backup`, `AITools`, `Admin`,  `DocsCloud`, `DocsCloudDevPack` or `AISearch` - and a name this installation does not sell answers 404.  Nothing has to be called first, the caller needs the permission to edit the portal settings, and the call is  read-only. The answer has the same shape as one item of `GET api/2.0/portal/payment/walletservices` - the  price of a unit, the unit, the limits the service grants and its service name - except that the variants of a  service are not grouped into `innerServices` here, because a single service is looked up directly. The price  is in the currency resolved for the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="service">The service to look up, given by its catalogue name. A service this installation does not sell answers 404,  and the whole catalogue is `GET api/2.0/portal/payment/walletservices`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-wallet-service/">REST API Reference for GetWalletService Operation</seealso>
        /// <returns>WalletServiceWrapper</returns>
        WalletServiceWrapper GetWalletService(TenantWalletService service);

        /// <summary>
        /// Get a wallet service
        /// </summary>
        /// <remarks>
        /// Returns one wallet service by name, for a client that already knows which service it needs and does not want  the whole catalogue. `service` is the name of the service - `Storage`, `Backup`, `AITools`, `Admin`,  `DocsCloud`, `DocsCloudDevPack` or `AISearch` - and a name this installation does not sell answers 404.  Nothing has to be called first, the caller needs the permission to edit the portal settings, and the call is  read-only. The answer has the same shape as one item of `GET api/2.0/portal/payment/walletservices` - the  price of a unit, the unit, the limits the service grants and its service name - except that the variants of a  service are not grouped into `innerServices` here, because a single service is looked up directly. The price  is in the currency resolved for the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="service">The service to look up, given by its catalogue name. A service this installation does not sell answers 404,  and the whole catalogue is `GET api/2.0/portal/payment/walletservices`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-wallet-service/">REST API Reference for GetWalletService Operation</seealso>
        /// <returns>ApiResponse of WalletServiceWrapper</returns>
        ApiResponse<WalletServiceWrapper> GetWalletServiceWithHttpInfo(TenantWalletService service);
        /// <summary>
        /// Get wallet services
        /// </summary>
        /// <remarks>
        /// Lists every service the portal may pay for out of its wallet - extra administrators, disk storage, backup, AI  tools, AI search and DocsCloud - with the price of a unit, the unit it is sold in and whether the portal has  it switched on. Nothing has to be called first, the caller needs the permission to edit the portal settings,  and the call is read-only. Services that are variants of one another are folded together: the visible one  carries the rest in its `innerServices`, so a client renders one card per group. The AI services are left out  entirely when AI is not enabled for the portal. This is the catalogue and not the state of the portal - what  is actually running is `GET api/2.0/portal/payment/activeservices`, one service on its own is  `GET api/2.0/portal/payment/walletservice`, and switching one on or off is  `POST api/2.0/portal/payment/servicestate`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-wallet-services/">REST API Reference for GetWalletServices Operation</seealso>
        /// <returns>WalletServiceArrayWrapper</returns>
        WalletServiceArrayWrapper GetWalletServices();

        /// <summary>
        /// Get wallet services
        /// </summary>
        /// <remarks>
        /// Lists every service the portal may pay for out of its wallet - extra administrators, disk storage, backup, AI  tools, AI search and DocsCloud - with the price of a unit, the unit it is sold in and whether the portal has  it switched on. Nothing has to be called first, the caller needs the permission to edit the portal settings,  and the call is read-only. Services that are variants of one another are folded together: the visible one  carries the rest in its `innerServices`, so a client renders one card per group. The AI services are left out  entirely when AI is not enabled for the portal. This is the catalogue and not the state of the portal - what  is actually running is `GET api/2.0/portal/payment/activeservices`, one service on its own is  `GET api/2.0/portal/payment/walletservice`, and switching one on or off is  `POST api/2.0/portal/payment/servicestate`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-wallet-services/">REST API Reference for GetWalletServices Operation</seealso>
        /// <returns>ApiResponse of WalletServiceArrayWrapper</returns>
        ApiResponse<WalletServiceArrayWrapper> GetWalletServicesWithHttpInfo();
        /// <summary>
        /// Move the subscription to the wallet
        /// </summary>
        /// <remarks>
        /// Ends the portal's paid subscription and moves it onto the wallet: the unused balance of the running period is  credited to the wallet, the wallet is topped up from the payment method on file if that credit does not cover  the purchase, and the requested number of administrators is then bought as a wallet service. The portal needs  a billing customer with a payment method set and a plan in the paid state, `quantity` has to name the  administrators wallet product, and the number asked for may not be below the administrators the portal already  has - read the credit that will be carried over from `GET api/2.0/portal/payment/subscription/balance` first.  Only the payer may call it. The call is mutating, spends money and cannot be undone: the subscription is ended  before the purchase is attempted, so a failure in the second half leaves the portal on the wallet with the  money credited but the administrators unbought, and a repeat would then buy them a second time. It is limited  to ten requests a minute per user by default. The result is `true` when the administrators were bought.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quantityRequestDto">The new size of the portal subscription. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-subscription-to-wallet/">REST API Reference for MoveSubscriptionToWallet Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper MoveSubscriptionToWallet(QuantityRequestDto? quantityRequestDto = default);

        /// <summary>
        /// Move the subscription to the wallet
        /// </summary>
        /// <remarks>
        /// Ends the portal's paid subscription and moves it onto the wallet: the unused balance of the running period is  credited to the wallet, the wallet is topped up from the payment method on file if that credit does not cover  the purchase, and the requested number of administrators is then bought as a wallet service. The portal needs  a billing customer with a payment method set and a plan in the paid state, `quantity` has to name the  administrators wallet product, and the number asked for may not be below the administrators the portal already  has - read the credit that will be carried over from `GET api/2.0/portal/payment/subscription/balance` first.  Only the payer may call it. The call is mutating, spends money and cannot be undone: the subscription is ended  before the purchase is attempted, so a failure in the second half leaves the portal on the wallet with the  money credited but the administrators unbought, and a repeat would then buy them a second time. It is limited  to ten requests a minute per user by default. The result is `true` when the administrators were bought.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quantityRequestDto">The new size of the portal subscription. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-subscription-to-wallet/">REST API Reference for MoveSubscriptionToWallet Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> MoveSubscriptionToWalletWithHttpInfo(QuantityRequestDto? quantityRequestDto = default);
        /// <summary>
        /// Contact the sales team
        /// </summary>
        /// <remarks>
        /// Sends the portal's message to the ONLYOFFICE sales team - the contact-sales form behind a request for a quote,  an invoice or a plan that cannot be bought online. `email` has to be a well-formed address and is where the  answer will go, while `userName` and `message` say who is asking and what for; all three are required and none  may be empty. Only a DocSpace administrator may call it. Nothing on the portal changes: no plan, no quota and  no payment is touched, a message is mailed out and the request is written to the portal audit trail. There is  no response body - status 200 means the message was handed to the mail service - and the call is not  idempotent, so a repeat sends a second message. It is limited to ten requests a minute per user by default and  answers 429 above that.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesRequestsDto">Who is writing to the ONLYOFFICE sales team, and what about. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-payment-request/">REST API Reference for SendPaymentRequest Operation</seealso>
        /// <returns></returns>
        void SendPaymentRequest(SalesRequestsDto? salesRequestsDto = default);

        /// <summary>
        /// Contact the sales team
        /// </summary>
        /// <remarks>
        /// Sends the portal's message to the ONLYOFFICE sales team - the contact-sales form behind a request for a quote,  an invoice or a plan that cannot be bought online. `email` has to be a well-formed address and is where the  answer will go, while `userName` and `message` say who is asking and what for; all three are required and none  may be empty. Only a DocSpace administrator may call it. Nothing on the portal changes: no plan, no quota and  no payment is touched, a message is mailed out and the request is written to the portal audit trail. There is  no response body - status 200 means the message was handed to the mail service - and the call is not  idempotent, so a repeat sends a second message. It is limited to ten requests a minute per user by default and  answers 429 above that.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesRequestsDto">Who is writing to the ONLYOFFICE sales team, and what about. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-payment-request/">REST API Reference for SendPaymentRequest Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> SendPaymentRequestWithHttpInfo(SalesRequestsDto? salesRequestsDto = default);
        /// <summary>
        /// Set restricted AI models
        /// </summary>
        /// <remarks>
        /// Replaces the whole set of AI chat models barred on this portal: the body is the complete set that is to hold,  so adding one restriction means sending the new model together with the ones already restricted, lifting one  means leaving it out, and an empty set lifts them all. Read the current set from  `GET api/2.0/portal/payment/ai-model/restrictions` and the model identifiers from  `GET api/2.0/portal/payment/ai-prices` before calling. The installation needs a billing service and the AI  gateway configured, the portal needs a billing customer, and the caller needs the permission to edit the  portal settings as well as DocSpace administrator rights. The call is mutating and idempotent - sending the  same set twice leaves the same state - and it is written to the portal audit trail. It takes effect on the  next AI request, so a conversation already open on a model that has just been barred cannot go on with it. The  stored set comes back in the answer.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setRestrictedAiModelsRequestDto">The complete set of AI chat models that are to be barred on the portal. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-restricted-ai-models/">REST API Reference for SetRestrictedAiModels Operation</seealso>
        /// <returns>RestrictedModelsResponseWrapper</returns>
        RestrictedModelsResponseWrapper SetRestrictedAiModels(SetRestrictedAiModelsRequestDto? setRestrictedAiModelsRequestDto = default);

        /// <summary>
        /// Set restricted AI models
        /// </summary>
        /// <remarks>
        /// Replaces the whole set of AI chat models barred on this portal: the body is the complete set that is to hold,  so adding one restriction means sending the new model together with the ones already restricted, lifting one  means leaving it out, and an empty set lifts them all. Read the current set from  `GET api/2.0/portal/payment/ai-model/restrictions` and the model identifiers from  `GET api/2.0/portal/payment/ai-prices` before calling. The installation needs a billing service and the AI  gateway configured, the portal needs a billing customer, and the caller needs the permission to edit the  portal settings as well as DocSpace administrator rights. The call is mutating and idempotent - sending the  same set twice leaves the same state - and it is written to the portal audit trail. It takes effect on the  next AI request, so a conversation already open on a model that has just been barred cannot go on with it. The  stored set comes back in the answer.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setRestrictedAiModelsRequestDto">The complete set of AI chat models that are to be barred on the portal. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-restricted-ai-models/">REST API Reference for SetRestrictedAiModels Operation</seealso>
        /// <returns>ApiResponse of RestrictedModelsResponseWrapper</returns>
        ApiResponse<RestrictedModelsResponseWrapper> SetRestrictedAiModelsWithHttpInfo(SetRestrictedAiModelsRequestDto? setRestrictedAiModelsRequestDto = default);
        /// <summary>
        /// Set the auto top-up settings
        /// </summary>
        /// <remarks>
        /// Switches the portal's automatic wallet top-up on or off and sets its thresholds: while it is on, the payment  method on file is charged whenever the wallet balance falls below `minBalance`, enough to bring it up to  `upToBalance`, in `currency`. The portal needs a billing customer whose wallet balance exists - a portal that  has never had one answers 404, so top the wallet up once with `POST api/2.0/portal/payment/deposit` first -  and only the payer may change the settings. The body replaces the stored settings as a whole and an omitted  body resets them to the defaults; `minBalance` is accepted between 5 and 1000 and `upToBalance` between 6 and  5000, while `lowBalanceThreshold` and `lowBalanceNotified` are ignored on the way in and kept as the portal  had them. The call is mutating and idempotent, it charges nothing by itself, it is written to the portal audit  trail, and switching the top-up on also re-arms the low-balance warning. The settings as they were stored come  back in the answer.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantWalletSettingsWrapper">The wrapper for the tenant wallet settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tenant-wallet-settings/">REST API Reference for SetTenantWalletSettings Operation</seealso>
        /// <returns>TenantWalletSettingsResponseWrapper</returns>
        TenantWalletSettingsResponseWrapper SetTenantWalletSettings(TenantWalletSettingsWrapper? tenantWalletSettingsWrapper = default);

        /// <summary>
        /// Set the auto top-up settings
        /// </summary>
        /// <remarks>
        /// Switches the portal's automatic wallet top-up on or off and sets its thresholds: while it is on, the payment  method on file is charged whenever the wallet balance falls below `minBalance`, enough to bring it up to  `upToBalance`, in `currency`. The portal needs a billing customer whose wallet balance exists - a portal that  has never had one answers 404, so top the wallet up once with `POST api/2.0/portal/payment/deposit` first -  and only the payer may change the settings. The body replaces the stored settings as a whole and an omitted  body resets them to the defaults; `minBalance` is accepted between 5 and 1000 and `upToBalance` between 6 and  5000, while `lowBalanceThreshold` and `lowBalanceNotified` are ignored on the way in and kept as the portal  had them. The call is mutating and idempotent, it charges nothing by itself, it is written to the portal audit  trail, and switching the top-up on also re-arms the low-balance warning. The settings as they were stored come  back in the answer.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantWalletSettingsWrapper">The wrapper for the tenant wallet settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tenant-wallet-settings/">REST API Reference for SetTenantWalletSettings Operation</seealso>
        /// <returns>ApiResponse of TenantWalletSettingsResponseWrapper</returns>
        ApiResponse<TenantWalletSettingsResponseWrapper> SetTenantWalletSettingsWithHttpInfo(TenantWalletSettingsWrapper? tenantWalletSettingsWrapper = default);
        /// <summary>
        /// Terminate the monthly usage report
        /// </summary>
        /// <remarks>
        /// Stops the `xlsx` monthly usage report this user has running and drops its task, for a report that was started  for the wrong period or is no longer wanted. The portal needs a billing customer and the caller has to be a  DocSpace administrator. The stop is asked of the worker that builds the file rather than done here, so  `GET api/2.0/portal/payment/customer/usage/monthly/report` can still answer for a moment afterwards. The call  is safe to repeat and does nothing at all when this user has no such report running: there is no response  body, and status 200 says the stop was requested, not that a report was really stopped. It leaves the  operations and service usage reports alone, and a report that had already finished keeps its file in My  documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-monthly-usage-report/">REST API Reference for TerminateCustomerMonthlyUsageReport Operation</seealso>
        /// <returns></returns>
        void TerminateCustomerMonthlyUsageReport();

        /// <summary>
        /// Terminate the monthly usage report
        /// </summary>
        /// <remarks>
        /// Stops the `xlsx` monthly usage report this user has running and drops its task, for a report that was started  for the wrong period or is no longer wanted. The portal needs a billing customer and the caller has to be a  DocSpace administrator. The stop is asked of the worker that builds the file rather than done here, so  `GET api/2.0/portal/payment/customer/usage/monthly/report` can still answer for a moment afterwards. The call  is safe to repeat and does nothing at all when this user has no such report running: there is no response  body, and status 200 says the stop was requested, not that a report was really stopped. It leaves the  operations and service usage reports alone, and a report that had already finished keeps its file in My  documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-monthly-usage-report/">REST API Reference for TerminateCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TerminateCustomerMonthlyUsageReportWithHttpInfo();
        /// <summary>
        /// Terminate the operations report
        /// </summary>
        /// <remarks>
        /// Stops the `xlsx` wallet operations report this user has running and drops its task, for a report that was  started with the wrong filters or is no longer wanted. The portal needs a billing customer and the caller has  to be a DocSpace administrator. The stop is asked of the worker that builds the file rather than done here, so  `GET api/2.0/portal/payment/customer/operationsreport` can still answer for a moment afterwards. The call is  safe to repeat and does nothing at all when this user has no report running: there is no response body, and  status 200 says the stop was requested, not that a report was really stopped. A report that had already  finished keeps its file in My documents - nothing is deleted from there.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-operations-report/">REST API Reference for TerminateCustomerOperationsReport Operation</seealso>
        /// <returns></returns>
        void TerminateCustomerOperationsReport();

        /// <summary>
        /// Terminate the operations report
        /// </summary>
        /// <remarks>
        /// Stops the `xlsx` wallet operations report this user has running and drops its task, for a report that was  started with the wrong filters or is no longer wanted. The portal needs a billing customer and the caller has  to be a DocSpace administrator. The stop is asked of the worker that builds the file rather than done here, so  `GET api/2.0/portal/payment/customer/operationsreport` can still answer for a moment afterwards. The call is  safe to repeat and does nothing at all when this user has no report running: there is no response body, and  status 200 says the stop was requested, not that a report was really stopped. A report that had already  finished keeps its file in My documents - nothing is deleted from there.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-operations-report/">REST API Reference for TerminateCustomerOperationsReport Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TerminateCustomerOperationsReportWithHttpInfo();
        /// <summary>
        /// Terminate the service usage report
        /// </summary>
        /// <remarks>
        /// Stops the `xlsx` service usage report this user has running and drops its task, for a report that was started  with the wrong filters or is no longer wanted. The portal needs a billing customer and the caller has to be a  DocSpace administrator. The stop is asked of the worker that builds the file rather than done here, so  `GET api/2.0/portal/payment/customer/usage/report` can still answer for a moment afterwards. The call is safe  to repeat and does nothing at all when this user has no such report running: there is no response body, and  status 200 says the stop was requested, not that a report was really stopped. It leaves the operations and  monthly usage reports alone, and a report that had already finished keeps its file in My documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-service-usage-report/">REST API Reference for TerminateCustomerServiceUsageReport Operation</seealso>
        /// <returns></returns>
        void TerminateCustomerServiceUsageReport();

        /// <summary>
        /// Terminate the service usage report
        /// </summary>
        /// <remarks>
        /// Stops the `xlsx` service usage report this user has running and drops its task, for a report that was started  with the wrong filters or is no longer wanted. The portal needs a billing customer and the caller has to be a  DocSpace administrator. The stop is asked of the worker that builds the file rather than done here, so  `GET api/2.0/portal/payment/customer/usage/report` can still answer for a moment afterwards. The call is safe  to repeat and does nothing at all when this user has no such report running: there is no response body, and  status 200 says the stop was requested, not that a report was really stopped. It leaves the operations and  monthly usage reports alone, and a report that had already finished keeps its file in My documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-service-usage-report/">REST API Reference for TerminateCustomerServiceUsageReport Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TerminateCustomerServiceUsageReportWithHttpInfo();
        /// <summary>
        /// Top up the wallet
        /// </summary>
        /// <remarks>
        /// Charges the payment method on file and adds the amount to the portal's wallet, the balance every wallet  service is paid from. The portal needs a billing customer with a payment method set - attach one with  `GET api/2.0/portal/payment/checkoutsetupurl` - `currency` has to be one of the accounting currencies this  installation supports, and `amount` is a whole number of currency units between 1 and 999999. Only the payer  may call it. The call takes money and is not idempotent in any way: two identical requests charge twice, so a  client must not retry it blindly after a timeout, and it is limited to ten requests a minute per user by  default. A successful top-up pushes the new balance to the portal clients over their socket connection and  re-arms the low-balance notification. The result is `true` when the payment provider accepted the charge; read  the resulting balance back from `GET api/2.0/portal/payment/customer/balance`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topUpDepositRequestDto">How much money is charged to the payment method on file and added to the portal wallet. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/top-up-deposit/">REST API Reference for TopUpDeposit Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper TopUpDeposit(TopUpDepositRequestDto? topUpDepositRequestDto = default);

        /// <summary>
        /// Top up the wallet
        /// </summary>
        /// <remarks>
        /// Charges the payment method on file and adds the amount to the portal's wallet, the balance every wallet  service is paid from. The portal needs a billing customer with a payment method set - attach one with  `GET api/2.0/portal/payment/checkoutsetupurl` - `currency` has to be one of the accounting currencies this  installation supports, and `amount` is a whole number of currency units between 1 and 999999. Only the payer  may call it. The call takes money and is not idempotent in any way: two identical requests charge twice, so a  client must not retry it blindly after a timeout, and it is limited to ten requests a minute per user by  default. A successful top-up pushes the new balance to the portal clients over their socket connection and  re-arms the low-balance notification. The result is `true` when the payment provider accepted the charge; read  the resulting balance back from `GET api/2.0/portal/payment/customer/balance`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topUpDepositRequestDto">How much money is charged to the payment method on file and added to the portal wallet. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/top-up-deposit/">REST API Reference for TopUpDeposit Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> TopUpDepositWithHttpInfo(TopUpDepositRequestDto? topUpDepositRequestDto = default);
        /// <summary>
        /// Change the subscription quantity
        /// </summary>
        /// <remarks>
        /// Changes how many units of the plan the portal is paying for - the number of administrators it covers - and  lets the payment provider bill the difference against the payment method already on file. The portal must have  a billing customer and a plan bought through `PUT api/2.0/portal/payment/url`, and while the portal is on a  priced plan the product name in `quantity` has to be that same plan, which `GET api/2.0/portal/payment/quota`  reports, because a subscription is changed here and not swapped. Only the payer - the portal user whose e-mail  is the billing customer's e-mail - may call it. The call is mutating and charges money, and it is guarded  against a double submission: once the new quantity is in effect, repeating the same request fails with 400  because that quantity is already set. The result is `true` when the provider accepted the change and `false`  when it declined it without an error. Exactly one product per call is accepted, the operation is limited to  ten requests a minute per user by default and answers 429 above that, and wallet services are not bought here  - use `PUT api/2.0/portal/payment/updatewallet` for those.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quantityRequestDto">The new size of the portal subscription. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-payment/">REST API Reference for UpdatePayment Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper UpdatePayment(QuantityRequestDto? quantityRequestDto = default);

        /// <summary>
        /// Change the subscription quantity
        /// </summary>
        /// <remarks>
        /// Changes how many units of the plan the portal is paying for - the number of administrators it covers - and  lets the payment provider bill the difference against the payment method already on file. The portal must have  a billing customer and a plan bought through `PUT api/2.0/portal/payment/url`, and while the portal is on a  priced plan the product name in `quantity` has to be that same plan, which `GET api/2.0/portal/payment/quota`  reports, because a subscription is changed here and not swapped. Only the payer - the portal user whose e-mail  is the billing customer's e-mail - may call it. The call is mutating and charges money, and it is guarded  against a double submission: once the new quantity is in effect, repeating the same request fails with 400  because that quantity is already set. The result is `true` when the provider accepted the change and `false`  when it declined it without an error. Exactly one product per call is accepted, the operation is limited to  ten requests a minute per user by default and answers 429 above that, and wallet services are not bought here  - use `PUT api/2.0/portal/payment/updatewallet` for those.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quantityRequestDto">The new size of the portal subscription. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-payment/">REST API Reference for UpdatePayment Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> UpdatePaymentWithHttpInfo(QuantityRequestDto? quantityRequestDto = default);
        /// <summary>
        /// Change a wallet service quantity
        /// </summary>
        /// <remarks>
        /// Buys more units of a wallet service - extra administrators, disk storage, backup, AI tools, AI search or  DocsCloud - or writes down the quantity that service will have after the next renewal, depending on  `productQuantityType`. With `Add` (1) the units are bought at once and paid out of the portal wallet, so the  wallet needs a sub-account in the accounting currency and enough money on it; with `Set` (0) nothing is  charged now and the quantity only takes effect in the next period, where an empty or zero quantity cancels a  change scheduled earlier. `Renew` and `Sub` are not accepted here. The portal needs a billing customer and the  caller has to be a DocSpace administrator; a service that is an add-on to the plan also needs the plan itself  to be paid, otherwise the answer is 402. Minimum quantities apply - disk storage starts at 100 units, the  DocsCloud developer pack at 10, and the administrators may not be fewer than the portal already has - and in  the `Add` form they are checked only while the portal does not hold that service yet. Asking for the DocsCloud  plan in the `Set` form while the developer pack is active schedules the reversion to it at the next period,  while the upgrade in the other direction is not done here at all: use  `POST api/2.0/settings/docscloud/switchtodevpack`. The result is `true` when the change was accepted; the call  is mutating, spends money in its `Add` form and is limited to ten requests a minute per user by default. Price  the same purchase without paying for it with `PUT api/2.0/portal/payment/calculatewallet`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The wallet service being bought or scheduled, and the way its quantity is applied. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-wallet-payment/">REST API Reference for UpdateWalletPayment Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper UpdateWalletPayment(WalletQuantityRequestDto? walletQuantityRequestDto = default);

        /// <summary>
        /// Change a wallet service quantity
        /// </summary>
        /// <remarks>
        /// Buys more units of a wallet service - extra administrators, disk storage, backup, AI tools, AI search or  DocsCloud - or writes down the quantity that service will have after the next renewal, depending on  `productQuantityType`. With `Add` (1) the units are bought at once and paid out of the portal wallet, so the  wallet needs a sub-account in the accounting currency and enough money on it; with `Set` (0) nothing is  charged now and the quantity only takes effect in the next period, where an empty or zero quantity cancels a  change scheduled earlier. `Renew` and `Sub` are not accepted here. The portal needs a billing customer and the  caller has to be a DocSpace administrator; a service that is an add-on to the plan also needs the plan itself  to be paid, otherwise the answer is 402. Minimum quantities apply - disk storage starts at 100 units, the  DocsCloud developer pack at 10, and the administrators may not be fewer than the portal already has - and in  the `Add` form they are checked only while the portal does not hold that service yet. Asking for the DocsCloud  plan in the `Set` form while the developer pack is active schedules the reversion to it at the next period,  while the upgrade in the other direction is not done here at all: use  `POST api/2.0/settings/docscloud/switchtodevpack`. The result is `true` when the change was accepted; the call  is mutating, spends money in its `Add` form and is limited to ten requests a minute per user by default. Price  the same purchase without paying for it with `PUT api/2.0/portal/payment/calculatewallet`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The wallet service being bought or scheduled, and the way its quantity is applied. (optional)</param>
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
        /// Prices a wallet-service purchase without making it: it returns what buying the requested number of units would  cost right now, so a client can show the amount before asking for a confirmation. Only `productQuantityType`  `Add` (1) is accepted, the quantity must be greater than zero, and the portal needs a billing customer whose  wallet has a sub-account in the accounting currency. The caller has to be a DocSpace administrator. Nothing is  bought, charged or written down - the call is read-only and may be repeated - and the purchase itself is  `PUT api/2.0/portal/payment/updatewallet`. The answer carries the amount with its currency, the quantity it  was computed for and the identifier of the calculation. It is the price of this moment and is not held: it can  differ by the time the purchase is made.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The wallet service being bought or scheduled, and the way its quantity is applied. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/calculate-wallet-payment/">REST API Reference for CalculateWalletPayment Operation</seealso>
        /// <returns>Task of PaymentCalculationWrapper</returns>
        Task<PaymentCalculationWrapper> CalculateWalletPaymentAsync(WalletQuantityRequestDto? walletQuantityRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Calculate the wallet payment amount
        /// </summary>
        /// <remarks>
        /// Prices a wallet-service purchase without making it: it returns what buying the requested number of units would  cost right now, so a client can show the amount before asking for a confirmation. Only `productQuantityType`  `Add` (1) is accepted, the quantity must be greater than zero, and the portal needs a billing customer whose  wallet has a sub-account in the accounting currency. The caller has to be a DocSpace administrator. Nothing is  bought, charged or written down - the call is read-only and may be repeated - and the purchase itself is  `PUT api/2.0/portal/payment/updatewallet`. The answer carries the amount with its currency, the quantity it  was computed for and the identifier of the calculation. It is the price of this moment and is not held: it can  differ by the time the purchase is made.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The wallet service being bought or scheduled, and the way its quantity is applied. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/calculate-wallet-payment/">REST API Reference for CalculateWalletPayment Operation</seealso>
        /// <returns>Task of ApiResponse (PaymentCalculationWrapper)</returns>
        Task<ApiResponse<PaymentCalculationWrapper>> CalculateWalletPaymentWithHttpInfoAsync(WalletQuantityRequestDto? walletQuantityRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Switch a wallet service
        /// </summary>
        /// <remarks>
        /// Switches one wallet service on or off for the portal: `service` names it and `enabled` says which way. The  portal needs a billing customer, and the caller needs both the permission to edit the portal settings and  DocSpace administrator rights. Order matters between the two AI services - AI tools has to be on before AI  search may be switched on, and switching AI tools off switches AI search off with it - so a request that  breaks that order is refused with 403. The call is mutating and idempotent: switching on a service that is  already on changes nothing. It is written to the portal audit trail, and switching AI tools notifies the  portal clients so the AI features appear or disappear for them without a reload. The whole updated set of  switched-on services comes back. Switching a service on does not buy it - its units are still bought with  `PUT api/2.0/portal/payment/updatewallet`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="changeWalletServiceStateRequestDto">Which wallet service is switched, and which way. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-tenant-wallet-service-state/">REST API Reference for ChangeTenantWalletServiceState Operation</seealso>
        /// <returns>Task of TenantWalletServiceSettingsWrapper</returns>
        Task<TenantWalletServiceSettingsWrapper> ChangeTenantWalletServiceStateAsync(ChangeWalletServiceStateRequestDto? changeWalletServiceStateRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Switch a wallet service
        /// </summary>
        /// <remarks>
        /// Switches one wallet service on or off for the portal: `service` names it and `enabled` says which way. The  portal needs a billing customer, and the caller needs both the permission to edit the portal settings and  DocSpace administrator rights. Order matters between the two AI services - AI tools has to be on before AI  search may be switched on, and switching AI tools off switches AI search off with it - so a request that  breaks that order is refused with 403. The call is mutating and idempotent: switching on a service that is  already on changes nothing. It is written to the portal audit trail, and switching AI tools notifies the  portal clients so the AI features appear or disappear for them without a reload. The whole updated set of  switched-on services comes back. Switching a service on does not buy it - its units are still bought with  `PUT api/2.0/portal/payment/updatewallet`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="changeWalletServiceStateRequestDto">Which wallet service is switched, and which way. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-tenant-wallet-service-state/">REST API Reference for ChangeTenantWalletServiceState Operation</seealso>
        /// <returns>Task of ApiResponse (TenantWalletServiceSettingsWrapper)</returns>
        Task<ApiResponse<TenantWalletServiceSettingsWrapper>> ChangeTenantWalletServiceStateWithHttpInfoAsync(ChangeWalletServiceStateRequestDto? changeWalletServiceStateRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Start the monthly usage report
        /// </summary>
        /// <remarks>
        /// Queues the wallet spending added up per calendar month as an `xlsx` file and returns the task that will build  it; the file is not ready when the response arrives. The portal needs a billing customer and the caller has to  be a DocSpace administrator. The body takes only the period - `startDate` and `endDate`, both inclusive - and  an empty body covers everything from the portal creation date to now; the months are cut in the portal time  zone, exactly as in `GET api/2.0/portal/payment/customer/usage/monthly`. Poll  `GET api/2.0/portal/payment/customer/usage/monthly/report` until `isCompleted` is true, then take the file  from `resultFileUrl` or open `resultFileId`: the finished file is saved into the caller's own My documents  section, where it counts against the portal storage like any other file. One monthly usage report per user is  tracked at a time - a call made while the previous one is still running answers with that task - and  `DELETE api/2.0/portal/payment/customer/usage/monthly/report` stops it. There is no service filter here: for a  report per service use `POST api/2.0/portal/payment/customer/usage/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerMonthlyUsageReportRequestDto">The period covered by the monthly wallet spending report. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-monthly-usage-report/">REST API Reference for CreateCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>Task of DocumentBuilderTaskWrapper</returns>
        Task<DocumentBuilderTaskWrapper> CreateCustomerMonthlyUsageReportAsync(CustomerMonthlyUsageReportRequestDto? customerMonthlyUsageReportRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Start the monthly usage report
        /// </summary>
        /// <remarks>
        /// Queues the wallet spending added up per calendar month as an `xlsx` file and returns the task that will build  it; the file is not ready when the response arrives. The portal needs a billing customer and the caller has to  be a DocSpace administrator. The body takes only the period - `startDate` and `endDate`, both inclusive - and  an empty body covers everything from the portal creation date to now; the months are cut in the portal time  zone, exactly as in `GET api/2.0/portal/payment/customer/usage/monthly`. Poll  `GET api/2.0/portal/payment/customer/usage/monthly/report` until `isCompleted` is true, then take the file  from `resultFileUrl` or open `resultFileId`: the finished file is saved into the caller's own My documents  section, where it counts against the portal storage like any other file. One monthly usage report per user is  tracked at a time - a call made while the previous one is still running answers with that task - and  `DELETE api/2.0/portal/payment/customer/usage/monthly/report` stops it. There is no service filter here: for a  report per service use `POST api/2.0/portal/payment/customer/usage/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerMonthlyUsageReportRequestDto">The period covered by the monthly wallet spending report. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-monthly-usage-report/">REST API Reference for CreateCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>Task of ApiResponse (DocumentBuilderTaskWrapper)</returns>
        Task<ApiResponse<DocumentBuilderTaskWrapper>> CreateCustomerMonthlyUsageReportWithHttpInfoAsync(CustomerMonthlyUsageReportRequestDto? customerMonthlyUsageReportRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Start the operations report
        /// </summary>
        /// <remarks>
        /// Queues the history of the wallet movements as an `xlsx` file and returns the task that will build it; the file  is not ready when the response arrives. The portal needs a billing customer and the caller has to be a  DocSpace administrator. The body takes the same filters as `GET api/2.0/portal/payment/customer/operations` -  the service names, the date range, the participant, the operation type and status, the credit and debit  directions and the ordering - and an empty body reports everything from the portal creation date to now; a  service name this installation does not sell fails with 404. Poll  `GET api/2.0/portal/payment/customer/operationsreport` until `isCompleted` is true, then take the file from  `resultFileUrl` or open `resultFileId`: the finished file is saved into the caller's own My documents section,  where it counts against the portal storage like any other file. One operations report per user is tracked at a  time - a call made while the previous one is still running answers with that task - and  `DELETE api/2.0/portal/payment/customer/operationsreport` stops it. A build that fails ends the task with  `error` filled in rather than failing this call.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerOperationsReportRequestDto">The filters that select which wallet movements are reported: the services, the period, the participant, the  direction and the outcome of the movement, and the ordering. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-operations-report/">REST API Reference for CreateCustomerOperationsReport Operation</seealso>
        /// <returns>Task of DocumentBuilderTaskWrapper</returns>
        Task<DocumentBuilderTaskWrapper> CreateCustomerOperationsReportAsync(CustomerOperationsReportRequestDto? customerOperationsReportRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Start the operations report
        /// </summary>
        /// <remarks>
        /// Queues the history of the wallet movements as an `xlsx` file and returns the task that will build it; the file  is not ready when the response arrives. The portal needs a billing customer and the caller has to be a  DocSpace administrator. The body takes the same filters as `GET api/2.0/portal/payment/customer/operations` -  the service names, the date range, the participant, the operation type and status, the credit and debit  directions and the ordering - and an empty body reports everything from the portal creation date to now; a  service name this installation does not sell fails with 404. Poll  `GET api/2.0/portal/payment/customer/operationsreport` until `isCompleted` is true, then take the file from  `resultFileUrl` or open `resultFileId`: the finished file is saved into the caller's own My documents section,  where it counts against the portal storage like any other file. One operations report per user is tracked at a  time - a call made while the previous one is still running answers with that task - and  `DELETE api/2.0/portal/payment/customer/operationsreport` stops it. A build that fails ends the task with  `error` filled in rather than failing this call.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerOperationsReportRequestDto">The filters that select which wallet movements are reported: the services, the period, the participant, the  direction and the outcome of the movement, and the ordering. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-operations-report/">REST API Reference for CreateCustomerOperationsReport Operation</seealso>
        /// <returns>Task of ApiResponse (DocumentBuilderTaskWrapper)</returns>
        Task<ApiResponse<DocumentBuilderTaskWrapper>> CreateCustomerOperationsReportWithHttpInfoAsync(CustomerOperationsReportRequestDto? customerOperationsReportRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Start the service usage report
        /// </summary>
        /// <remarks>
        /// Queues the usage of the wallet services as an `xlsx` file and returns the task that will build it; the file is  not ready when the response arrives. The portal needs a billing customer and the caller has to be a DocSpace  administrator. The body takes the same filters as `GET api/2.0/portal/payment/customer/usage` - the service  names, the date range, the participant, the operation status, the usage metadata and the ordering - and an  empty body reports every service from the portal creation date to now; a service name this installation does  not sell fails with 404. Poll `GET api/2.0/portal/payment/customer/usage/report` until `isCompleted` is true,  then take the file from `resultFileUrl` or open `resultFileId`: the finished file is saved into the caller's  own My documents section, where it counts against the portal storage like any other file. One service usage  report per user is tracked at a time - a call made while the previous one is still running answers with that  task - and `DELETE api/2.0/portal/payment/customer/usage/report` stops it. It is a different report from the  operations one and does not interfere with it: per-movement history is  `POST api/2.0/portal/payment/customer/operationsreport`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerServiceUsageReportRequestDto">The filters that select which wallet service consumption is reported: the services, the period, the participant,  the outcome, the usage metadata and the ordering. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-service-usage-report/">REST API Reference for CreateCustomerServiceUsageReport Operation</seealso>
        /// <returns>Task of DocumentBuilderTaskWrapper</returns>
        Task<DocumentBuilderTaskWrapper> CreateCustomerServiceUsageReportAsync(CustomerServiceUsageReportRequestDto? customerServiceUsageReportRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Start the service usage report
        /// </summary>
        /// <remarks>
        /// Queues the usage of the wallet services as an `xlsx` file and returns the task that will build it; the file is  not ready when the response arrives. The portal needs a billing customer and the caller has to be a DocSpace  administrator. The body takes the same filters as `GET api/2.0/portal/payment/customer/usage` - the service  names, the date range, the participant, the operation status, the usage metadata and the ordering - and an  empty body reports every service from the portal creation date to now; a service name this installation does  not sell fails with 404. Poll `GET api/2.0/portal/payment/customer/usage/report` until `isCompleted` is true,  then take the file from `resultFileUrl` or open `resultFileId`: the finished file is saved into the caller's  own My documents section, where it counts against the portal storage like any other file. One service usage  report per user is tracked at a time - a call made while the previous one is still running answers with that  task - and `DELETE api/2.0/portal/payment/customer/usage/report` stops it. It is a different report from the  operations one and does not interfere with it: per-movement history is  `POST api/2.0/portal/payment/customer/operationsreport`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerServiceUsageReportRequestDto">The filters that select which wallet service consumption is reported: the services, the period, the participant,  the outcome, the usage metadata and the ordering. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-service-usage-report/">REST API Reference for CreateCustomerServiceUsageReport Operation</seealso>
        /// <returns>Task of ApiResponse (DocumentBuilderTaskWrapper)</returns>
        Task<ApiResponse<DocumentBuilderTaskWrapper>> CreateCustomerServiceUsageReportWithHttpInfoAsync(CustomerServiceUsageReportRequestDto? customerServiceUsageReportRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the service prices from the accounting service
        /// </summary>
        /// <remarks>
        /// Returns the portal's automatic wallet top-up settings: whether it is switched on, the balance that triggers  it, the balance it tops the wallet up to and the currency it charges in. Only a DocSpace administrator may  read it, no billing customer is needed, and the call is read-only. A portal that has never configured it gets  the defaults rather than an empty result, so `enabled` is the field that says whether anything happens at all.  Two of the values are kept by the portal itself and cannot be set through this API: `lowBalanceThreshold` is  the balance below which the portal warns its administrators by mail, and `lowBalanceNotified` says whether  that warning has already gone out for the current dip. Change the rest with  `POST api/2.0/portal/payment/topupsettings`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName">The service whose price list is read, named the way the billing catalogue names it, such as `ai-tools` or  `backup`. Take the value from the `serviceName` field of `GET api/2.0/portal/payment/walletservices`; a name  the accounting service does not price yields an empty list rather than an error.</param>
        /// <param name="active">Whether the answer is narrowed to the prices in force at the moment of the call. Leaving it false also  returns the retired and the not yet started ones, which is what pricing a movement recorded in the past  needs. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounting-service-prices/">REST API Reference for GetAccountingServicePrices Operation</seealso>
        /// <returns>Task of ServicePriceInfoArrayWrapper</returns>
        Task<ServicePriceInfoArrayWrapper> GetAccountingServicePricesAsync(string serviceName, bool? active = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the service prices from the accounting service
        /// </summary>
        /// <remarks>
        /// Returns the portal's automatic wallet top-up settings: whether it is switched on, the balance that triggers  it, the balance it tops the wallet up to and the currency it charges in. Only a DocSpace administrator may  read it, no billing customer is needed, and the call is read-only. A portal that has never configured it gets  the defaults rather than an empty result, so `enabled` is the field that says whether anything happens at all.  Two of the values are kept by the portal itself and cannot be set through this API: `lowBalanceThreshold` is  the balance below which the portal warns its administrators by mail, and `lowBalanceNotified` says whether  that warning has already gone out for the current dip. Change the rest with  `POST api/2.0/portal/payment/topupsettings`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName">The service whose price list is read, named the way the billing catalogue names it, such as `ai-tools` or  `backup`. Take the value from the `serviceName` field of `GET api/2.0/portal/payment/walletservices`; a name  the accounting service does not price yields an empty list rather than an error.</param>
        /// <param name="active">Whether the answer is narrowed to the prices in force at the moment of the call. Leaving it false also  returns the retired and the not yet started ones, which is what pricing a movement recorded in the past  needs. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounting-service-prices/">REST API Reference for GetAccountingServicePrices Operation</seealso>
        /// <returns>Task of ApiResponse (ServicePriceInfoArrayWrapper)</returns>
        Task<ApiResponse<ServicePriceInfoArrayWrapper>> GetAccountingServicePricesWithHttpInfoAsync(string serviceName, bool? active = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the active wallet services
        /// </summary>
        /// <remarks>
        /// Lists the wallet services the portal is running right now: the add-ons its plan pays for that are in the  active state, plus the ones an administrator switched on by hand in the wallet service settings; the DocsCloud  trial is listed as well, although it is not paid from the wallet. Only a DocSpace administrator may call it,  no billing customer is needed for it, and the call is read-only. Every item names the service, its title and  the unit it is measured in, and says whether it is a subscription; a subscribed service also carries the limit  it grants and how much of it is used where that number is known - the editor seats and the editors currently  active for DocsCloud, the purchased units and the units already consumed for disk storage. A service listed  with no limit is one whose usage is not counted this way, not one without a limit. The catalogue of what could  be switched on is `GET api/2.0/portal/payment/walletservices`, and switching one is  `POST api/2.0/portal/payment/servicestate`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-active-services/">REST API Reference for GetActiveServices Operation</seealso>
        /// <returns>Task of ActiveServiceArrayWrapper</returns>
        Task<ActiveServiceArrayWrapper> GetActiveServicesAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the active wallet services
        /// </summary>
        /// <remarks>
        /// Lists the wallet services the portal is running right now: the add-ons its plan pays for that are in the  active state, plus the ones an administrator switched on by hand in the wallet service settings; the DocsCloud  trial is listed as well, although it is not paid from the wallet. Only a DocSpace administrator may call it,  no billing customer is needed for it, and the call is read-only. Every item names the service, its title and  the unit it is measured in, and says whether it is a subscription; a subscribed service also carries the limit  it grants and how much of it is used where that number is known - the editor seats and the editors currently  active for DocsCloud, the purchased units and the units already consumed for disk storage. A service listed  with no limit is one whose usage is not counted this way, not one without a limit. The catalogue of what could  be switched on is `GET api/2.0/portal/payment/walletservices`, and switching one is  `POST api/2.0/portal/payment/servicestate`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-active-services/">REST API Reference for GetActiveServices Operation</seealso>
        /// <returns>Task of ApiResponse (ActiveServiceArrayWrapper)</returns>
        Task<ApiResponse<ActiveServiceArrayWrapper>> GetActiveServicesWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get AI model prices
        /// </summary>
        /// <remarks>
        /// Returns the price list of the AI features the portal pays for out of its wallet: the chat models with the  price of their prompt and completion tokens, the embedding models, the image models with their per-image  price, and the web search providers with the price of one search. The installation needs both a billing  service and the AI gateway configured, otherwise the answer is 403, and only a DocSpace administrator may read  it; the call is read-only. Token prices are normalised per million tokens, and every price is in the single  `currency` the answer names. Each entry carries the model identifier to use when talking to the AI operations,  its display alias, its provider with the provider icon, and a link to the model's own page. It is a list of  what the models cost and not of what the portal spent - that is `GET api/2.0/portal/payment/customer/usage` -  and it says nothing about which of them are allowed here, which is  `GET api/2.0/portal/payment/ai-model/restrictions`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-ai-prices/">REST API Reference for GetAiPrices Operation</seealso>
        /// <returns>Task of AiPricesWrapper</returns>
        Task<AiPricesWrapper> GetAiPricesAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get AI model prices
        /// </summary>
        /// <remarks>
        /// Returns the price list of the AI features the portal pays for out of its wallet: the chat models with the  price of their prompt and completion tokens, the embedding models, the image models with their per-image  price, and the web search providers with the price of one search. The installation needs both a billing  service and the AI gateway configured, otherwise the answer is 403, and only a DocSpace administrator may read  it; the call is read-only. Token prices are normalised per million tokens, and every price is in the single  `currency` the answer names. Each entry carries the model identifier to use when talking to the AI operations,  its display alias, its provider with the provider icon, and a link to the model's own page. It is a list of  what the models cost and not of what the portal spent - that is `GET api/2.0/portal/payment/customer/usage` -  and it says nothing about which of them are allowed here, which is  `GET api/2.0/portal/payment/ai-model/restrictions`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-ai-prices/">REST API Reference for GetAiPrices Operation</seealso>
        /// <returns>Task of ApiResponse (AiPricesWrapper)</returns>
        Task<ApiResponse<AiPricesWrapper>> GetAiPricesWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the checkout setup page URL
        /// </summary>
        /// <remarks>
        /// Hands back the hosted page on which a payment method is attached to the portal's billing account, for the case  where money has to be taken later - a wallet top-up or an automatic one - rather than a plan bought now. A  portal that already has a payment method on file answers with an empty result; a DocSpace administrator may  ask for the page, but once the portal has a billing customer with an e-mail, only its payer may. The call  itself changes nothing and may be repeated: the payment method is stored by the payment provider when the  returned page is completed, after which `GET api/2.0/portal/payment/customerinfo` reports it as set. The URL  is absolute, carries the caller's e-mail, the language of the request and the currency of the region, and  redirects to `successUrl` or `backUrl` when the user finishes or cancels. It buys nothing - a plan is bought  with `PUT api/2.0/portal/payment/url`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">The absolute address the setup page sends the user back to when attaching a payment method is abandoned. It  has to be a well-formed URL and must be reachable by that user rather than by the portal.</param>
        /// <param name="successUrl">The absolute address the setup page sends the user to once the payment provider has stored the payment  method. Reaching it means a method is now on file, which `GET api/2.0/portal/payment/customerinfo` confirms;  nothing has been charged.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-checkout-setup-url/">REST API Reference for GetCheckoutSetupUrl Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        Task<StringWrapper> GetCheckoutSetupUrlAsync(string backUrl, string successUrl, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the checkout setup page URL
        /// </summary>
        /// <remarks>
        /// Hands back the hosted page on which a payment method is attached to the portal's billing account, for the case  where money has to be taken later - a wallet top-up or an automatic one - rather than a plan bought now. A  portal that already has a payment method on file answers with an empty result; a DocSpace administrator may  ask for the page, but once the portal has a billing customer with an e-mail, only its payer may. The call  itself changes nothing and may be repeated: the payment method is stored by the payment provider when the  returned page is completed, after which `GET api/2.0/portal/payment/customerinfo` reports it as set. The URL  is absolute, carries the caller's e-mail, the language of the request and the currency of the region, and  redirects to `successUrl` or `backUrl` when the user finishes or cancels. It buys nothing - a plan is bought  with `PUT api/2.0/portal/payment/url`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">The absolute address the setup page sends the user back to when attaching a payment method is abandoned. It  has to be a well-formed URL and must be reachable by that user rather than by the portal.</param>
        /// <param name="successUrl">The absolute address the setup page sends the user to once the payment provider has stored the payment  method. Reaching it means a method is now on file, which `GET api/2.0/portal/payment/customerinfo` confirms;  nothing has been charged.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-checkout-setup-url/">REST API Reference for GetCheckoutSetupUrl Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        Task<ApiResponse<StringWrapper>> GetCheckoutSetupUrlWithHttpInfoAsync(string backUrl, string successUrl, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the customer balance
        /// </summary>
        /// <remarks>
        /// Returns the money the portal has in its wallet as the accounting service holds it: the account with its own  currency, one sub-account per currency with the amount on it, and the most recent credit movement. Only a  DocSpace administrator may read it, an installation without a billing service answers 403, and a portal that  has never been a customer gets an empty result. The call is read-only. This balance is what the wallet  services are charged against, so it falls as they are used and rises with  `POST api/2.0/portal/payment/deposit`; the movements behind a change are listed by  `GET api/2.0/portal/payment/customer/operations`. Pass `refresh=true` to re-read it from the accounting  service rather than the cache - right after a top-up the cached figure is still the old one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Whether the answer is fetched from the billing service instead of the portal cache. The cached copy is what a  start-up needs and costs nothing; asking for a fresh one makes a remote call, so use it right after a  purchase or a top-up and not on every read. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-balance/">REST API Reference for GetCustomerBalance Operation</seealso>
        /// <returns>Task of BalanceWrapper</returns>
        Task<BalanceWrapper> GetCustomerBalanceAsync(bool? refresh = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the customer balance
        /// </summary>
        /// <remarks>
        /// Returns the money the portal has in its wallet as the accounting service holds it: the account with its own  currency, one sub-account per currency with the amount on it, and the most recent credit movement. Only a  DocSpace administrator may read it, an installation without a billing service answers 403, and a portal that  has never been a customer gets an empty result. The call is read-only. This balance is what the wallet  services are charged against, so it falls as they are used and rises with  `POST api/2.0/portal/payment/deposit`; the movements behind a change are listed by  `GET api/2.0/portal/payment/customer/operations`. Pass `refresh=true` to re-read it from the accounting  service rather than the cache - right after a top-up the cached figure is still the old one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Whether the answer is fetched from the billing service instead of the portal cache. The cached copy is what a  start-up needs and costs nothing; asking for a fresh one makes a remote call, so use it right after a  purchase or a top-up and not on every read. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-balance/">REST API Reference for GetCustomerBalance Operation</seealso>
        /// <returns>Task of ApiResponse (BalanceWrapper)</returns>
        Task<ApiResponse<BalanceWrapper>> GetCustomerBalanceWithHttpInfoAsync(bool? refresh = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the customer information
        /// </summary>
        /// <remarks>
        /// Returns the billing customer behind the portal: the e-mail its billing account is registered to, whether a  payment method is stored for it, and the portal user who is the payer of that account. Only a DocSpace  administrator may read it, and the call is read-only. The answer is empty in two ordinary cases - the  installation has no billing service configured at all, and the portal has never been a customer - so an empty  body is not an error. `payer` is filled in only when the billing e-mail belongs to a portal user; when it does  not, the e-mail is still shown but the field stays empty, and that is what makes every payer-only operation of  this group unreachable for everybody. `refresh=true` re-reads the customer from the billing provider instead  of the cache, which is worth doing right after a payment method has been attached.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Whether the answer is fetched from the billing service instead of the portal cache. The cached copy is what a  start-up needs and costs nothing; asking for a fresh one makes a remote call, so use it right after a  purchase or a top-up and not on every read. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-info/">REST API Reference for GetCustomerInfo Operation</seealso>
        /// <returns>Task of CustomerInfoWrapper</returns>
        Task<CustomerInfoWrapper> GetCustomerInfoAsync(bool? refresh = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the customer information
        /// </summary>
        /// <remarks>
        /// Returns the billing customer behind the portal: the e-mail its billing account is registered to, whether a  payment method is stored for it, and the portal user who is the payer of that account. Only a DocSpace  administrator may read it, and the call is read-only. The answer is empty in two ordinary cases - the  installation has no billing service configured at all, and the portal has never been a customer - so an empty  body is not an error. `payer` is filled in only when the billing e-mail belongs to a portal user; when it does  not, the e-mail is still shown but the field stays empty, and that is what makes every payer-only operation of  this group unreachable for everybody. `refresh=true` re-reads the customer from the billing provider instead  of the cache, which is worth doing right after a payment method has been attached.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Whether the answer is fetched from the billing service instead of the portal cache. The cached copy is what a  start-up needs and costs nothing; asking for a fresh one makes a remote call, so use it right after a  purchase or a top-up and not on every read. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-info/">REST API Reference for GetCustomerInfo Operation</seealso>
        /// <returns>Task of ApiResponse (CustomerInfoWrapper)</returns>
        Task<ApiResponse<CustomerInfoWrapper>> GetCustomerInfoWithHttpInfoAsync(bool? refresh = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the customer monthly usage
        /// </summary>
        /// <remarks>
        /// Returns what the portal spent from its wallet added up per calendar month, so a client can draw a spending  chart without paging through every movement. Only a DocSpace administrator may read it, a portal with no  billing customer answers with an empty result, and the call is read-only. `startDate` and `endDate` bound the  period, both inclusive, and default to the portal creation date and the present moment; the months are cut in  the portal time zone, so a movement at the edge of a month falls where the portal sees it and not where UTC  does. Each item names its year and month, the total charged in it with the currency, and how many operations  that total came from. The movements behind a month are in `GET api/2.0/portal/payment/customer/operations`,  and the same figures as a file come from `POST api/2.0/portal/payment/customer/usage/monthly/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The beginning of the reported period, inclusive. The months are cut in the portal time zone rather than in  UTC, so spending at the turn of a month falls where the portal sees it; defaults to the portal creation date. (optional)</param>
        /// <param name="endDate">The end of the reported period, inclusive. Cut in the portal time zone in the same way as `startDate`, and  defaults to the moment the call is made. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-monthly-usage/">REST API Reference for GetCustomerMonthlyUsage Operation</seealso>
        /// <returns>Task of CustomerMonthlyUsageArrayWrapper</returns>
        Task<CustomerMonthlyUsageArrayWrapper> GetCustomerMonthlyUsageAsync(DateTime? startDate = default, DateTime? endDate = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the customer monthly usage
        /// </summary>
        /// <remarks>
        /// Returns what the portal spent from its wallet added up per calendar month, so a client can draw a spending  chart without paging through every movement. Only a DocSpace administrator may read it, a portal with no  billing customer answers with an empty result, and the call is read-only. `startDate` and `endDate` bound the  period, both inclusive, and default to the portal creation date and the present moment; the months are cut in  the portal time zone, so a movement at the edge of a month falls where the portal sees it and not where UTC  does. Each item names its year and month, the total charged in it with the currency, and how many operations  that total came from. The movements behind a month are in `GET api/2.0/portal/payment/customer/operations`,  and the same figures as a file come from `POST api/2.0/portal/payment/customer/usage/monthly/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The beginning of the reported period, inclusive. The months are cut in the portal time zone rather than in  UTC, so spending at the turn of a month falls where the portal sees it; defaults to the portal creation date. (optional)</param>
        /// <param name="endDate">The end of the reported period, inclusive. Cut in the portal time zone in the same way as `startDate`, and  defaults to the moment the call is made. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-monthly-usage/">REST API Reference for GetCustomerMonthlyUsage Operation</seealso>
        /// <returns>Task of ApiResponse (CustomerMonthlyUsageArrayWrapper)</returns>
        Task<ApiResponse<CustomerMonthlyUsageArrayWrapper>> GetCustomerMonthlyUsageWithHttpInfoAsync(DateTime? startDate = default, DateTime? endDate = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the monthly usage report status
        /// </summary>
        /// <remarks>
        /// Returns the state of the `xlsx` monthly usage report this user started with  `POST api/2.0/portal/payment/customer/usage/monthly/report`: `percentage` while it is being built,  `isCompleted` when it is done, `resultFileId`, `resultFileName` and `resultFileUrl` pointing at the file in  the caller's My documents, and `error` when the build failed. The portal needs a billing customer and the  caller has to be a DocSpace administrator; the call is read-only and is the one to poll. The task is kept per  user and per report kind, so it reports neither another administrator's report nor the operations and service  usage ones, which have their own status operations. An empty result means this user has no monthly usage  report at all - none was started, or the finished one was already picked up or terminated. A completed task is  dropped as soon as the next report is started, so read the file link out of the same answer that first reports  `isCompleted`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-monthly-usage-report/">REST API Reference for GetCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>Task of DocumentBuilderTaskWrapper</returns>
        Task<DocumentBuilderTaskWrapper> GetCustomerMonthlyUsageReportAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the monthly usage report status
        /// </summary>
        /// <remarks>
        /// Returns the state of the `xlsx` monthly usage report this user started with  `POST api/2.0/portal/payment/customer/usage/monthly/report`: `percentage` while it is being built,  `isCompleted` when it is done, `resultFileId`, `resultFileName` and `resultFileUrl` pointing at the file in  the caller's My documents, and `error` when the build failed. The portal needs a billing customer and the  caller has to be a DocSpace administrator; the call is read-only and is the one to poll. The task is kept per  user and per report kind, so it reports neither another administrator's report nor the operations and service  usage ones, which have their own status operations. An empty result means this user has no monthly usage  report at all - none was started, or the finished one was already picked up or terminated. A completed task is  dropped as soon as the next report is started, so read the file link out of the same answer that first reports  `isCompleted`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-monthly-usage-report/">REST API Reference for GetCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>Task of ApiResponse (DocumentBuilderTaskWrapper)</returns>
        Task<ApiResponse<DocumentBuilderTaskWrapper>> GetCustomerMonthlyUsageReportWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the wallet operations
        /// </summary>
        /// <remarks>
        /// Lists the money movements on the portal's wallet - top-ups, the charges of the wallet services, refunds and  corrections - one page at a time, which is what a billing history is built from. Only a DocSpace administrator  may read it, a portal with no billing customer answers with an empty result, and the call is read-only. Every  filter is optional: `startDate` and `endDate` are read in the portal time zone and default to the portal  creation date and the present moment, `serviceName` narrows to particular wallet services and fails with 404  on a name this installation does not sell, `participantName`, `type` and `status` narrow to who caused a  movement and how it ended, and `credit` and `debit` include or exclude the two directions. `offset` and  `limit` page through the result and default to 0 and 25, `orderBy` and `orderType` sort it, and the answer  repeats them next to `totalQuantity`, `totalPage` and `currentPage` so a client can page without counting. The  same data as a downloadable file is `POST api/2.0/portal/payment/customer/operationsreport`, and the figures  added up per service are `GET api/2.0/portal/payment/customer/usage`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">The number of movements to skip before the first one returned, for walking through a long history page by  page. Counted after the filters and the ordering are applied, and starts at 0 when omitted. (optional)</param>
        /// <param name="limit">The maximum number of movements returned in one page. Defaults to 25 when omitted; the answer echoes the  window back next to `totalQuantity`, `totalPage` and `currentPage`, so the next `offset` can be computed  without counting the items. (optional)</param>
        /// <param name="serviceName">The wallet services whose movements are kept, named the way the billing catalogue names them - `backup`,  `ai-tools`, `ai-search`, `disk-storage`, `docscloud`. Take the values from the `serviceName` field of  `GET api/2.0/portal/payment/walletservices`; the match ignores case, a name this installation does not sell  fails the call with 404, and an omitted list keeps every service. A bare string is accepted in place of an  array for backward compatibility. (optional)</param>
        /// <param name="startDate">The beginning of the reported period, inclusive. Read in the portal time zone rather than in UTC, so a  movement at the edge of the period falls where the portal sees it; defaults to the portal creation date. (optional)</param>
        /// <param name="endDate">The end of the reported period, inclusive. Read in the portal time zone rather than in UTC, and defaults to  the moment the call is made. (optional)</param>
        /// <param name="participantName">The participant whose movements are kept - the account the accounting service records as the cause of a  movement. A movement caused by a portal user carries that user ID here, and one caused by the portal itself  carries the customer name; surrounding whitespace is trimmed, and an omitted value keeps every participant. (optional)</param>
        /// <param name="credit">Whether movements that add money to the wallet - top-ups, refunds and corrections in the portal's favour -  are kept. Both directions are reported when neither this nor `debit` is given. (optional)</param>
        /// <param name="debit">Whether movements that take money out of the wallet - the charges of the wallet services - are kept. Both  directions are reported when neither this nor `credit` is given. (optional)</param>
        /// <param name="type">The kind of movement to keep, which says what caused the money to move rather than how it ended. Every kind  is reported when it is omitted. (optional)</param>
        /// <param name="status">The outcome to keep. A movement that is still being settled is reported as pending and may change later,  while the other outcomes are final; every outcome is reported when this is omitted. (optional)</param>
        /// <param name="orderBy">The name of the field the movements are sorted by, spelled as the accounting service names it, such as  `StartDate` or `ServiceName`. Surrounding whitespace is trimmed, and the accounting service applies its own  ordering when this is omitted. (optional)</param>
        /// <param name="orderType">The direction the field named in `orderBy` is sorted in. Newest or largest first is what the accounting  service does by default, so leaving this out sorts the same way as asking for descending explicitly. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-operations/">REST API Reference for GetCustomerOperations Operation</seealso>
        /// <returns>Task of ReportWrapper</returns>
        Task<ReportWrapper> GetCustomerOperationsAsync(int? offset = default, int? limit = default, List<string>? serviceName = default, DateTime? startDate = default, DateTime? endDate = default, string? participantName = default, bool? credit = default, bool? debit = default, OperationType? type = default, OperationStatus? status = default, string? orderBy = default, OperationOrderType? orderType = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the wallet operations
        /// </summary>
        /// <remarks>
        /// Lists the money movements on the portal's wallet - top-ups, the charges of the wallet services, refunds and  corrections - one page at a time, which is what a billing history is built from. Only a DocSpace administrator  may read it, a portal with no billing customer answers with an empty result, and the call is read-only. Every  filter is optional: `startDate` and `endDate` are read in the portal time zone and default to the portal  creation date and the present moment, `serviceName` narrows to particular wallet services and fails with 404  on a name this installation does not sell, `participantName`, `type` and `status` narrow to who caused a  movement and how it ended, and `credit` and `debit` include or exclude the two directions. `offset` and  `limit` page through the result and default to 0 and 25, `orderBy` and `orderType` sort it, and the answer  repeats them next to `totalQuantity`, `totalPage` and `currentPage` so a client can page without counting. The  same data as a downloadable file is `POST api/2.0/portal/payment/customer/operationsreport`, and the figures  added up per service are `GET api/2.0/portal/payment/customer/usage`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">The number of movements to skip before the first one returned, for walking through a long history page by  page. Counted after the filters and the ordering are applied, and starts at 0 when omitted. (optional)</param>
        /// <param name="limit">The maximum number of movements returned in one page. Defaults to 25 when omitted; the answer echoes the  window back next to `totalQuantity`, `totalPage` and `currentPage`, so the next `offset` can be computed  without counting the items. (optional)</param>
        /// <param name="serviceName">The wallet services whose movements are kept, named the way the billing catalogue names them - `backup`,  `ai-tools`, `ai-search`, `disk-storage`, `docscloud`. Take the values from the `serviceName` field of  `GET api/2.0/portal/payment/walletservices`; the match ignores case, a name this installation does not sell  fails the call with 404, and an omitted list keeps every service. A bare string is accepted in place of an  array for backward compatibility. (optional)</param>
        /// <param name="startDate">The beginning of the reported period, inclusive. Read in the portal time zone rather than in UTC, so a  movement at the edge of the period falls where the portal sees it; defaults to the portal creation date. (optional)</param>
        /// <param name="endDate">The end of the reported period, inclusive. Read in the portal time zone rather than in UTC, and defaults to  the moment the call is made. (optional)</param>
        /// <param name="participantName">The participant whose movements are kept - the account the accounting service records as the cause of a  movement. A movement caused by a portal user carries that user ID here, and one caused by the portal itself  carries the customer name; surrounding whitespace is trimmed, and an omitted value keeps every participant. (optional)</param>
        /// <param name="credit">Whether movements that add money to the wallet - top-ups, refunds and corrections in the portal's favour -  are kept. Both directions are reported when neither this nor `debit` is given. (optional)</param>
        /// <param name="debit">Whether movements that take money out of the wallet - the charges of the wallet services - are kept. Both  directions are reported when neither this nor `credit` is given. (optional)</param>
        /// <param name="type">The kind of movement to keep, which says what caused the money to move rather than how it ended. Every kind  is reported when it is omitted. (optional)</param>
        /// <param name="status">The outcome to keep. A movement that is still being settled is reported as pending and may change later,  while the other outcomes are final; every outcome is reported when this is omitted. (optional)</param>
        /// <param name="orderBy">The name of the field the movements are sorted by, spelled as the accounting service names it, such as  `StartDate` or `ServiceName`. Surrounding whitespace is trimmed, and the accounting service applies its own  ordering when this is omitted. (optional)</param>
        /// <param name="orderType">The direction the field named in `orderBy` is sorted in. Newest or largest first is what the accounting  service does by default, so leaving this out sorts the same way as asking for descending explicitly. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-operations/">REST API Reference for GetCustomerOperations Operation</seealso>
        /// <returns>Task of ApiResponse (ReportWrapper)</returns>
        Task<ApiResponse<ReportWrapper>> GetCustomerOperationsWithHttpInfoAsync(int? offset = default, int? limit = default, List<string>? serviceName = default, DateTime? startDate = default, DateTime? endDate = default, string? participantName = default, bool? credit = default, bool? debit = default, OperationType? type = default, OperationStatus? status = default, string? orderBy = default, OperationOrderType? orderType = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the operations report status
        /// </summary>
        /// <remarks>
        /// Returns the state of the `xlsx` wallet operations report this user started with  `POST api/2.0/portal/payment/customer/operationsreport`: `percentage` while it is being built, `isCompleted`  when it is done, `resultFileId`, `resultFileName` and `resultFileUrl` pointing at the file in the caller's My  documents, and `error` when the build failed. The portal needs a billing customer and the caller has to be a  DocSpace administrator; the call is read-only and is the one to poll. The task is kept per user and per report  kind, so it never reports another administrator's report, nor the service usage and monthly usage ones, which  have their own status operations. An empty result means this user has no operations report at all - none was  started, or the finished one was already picked up or terminated. A completed task is dropped as soon as the  next report is started, so read the file link out of the same answer that first reports `isCompleted`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-operations-report/">REST API Reference for GetCustomerOperationsReport Operation</seealso>
        /// <returns>Task of DocumentBuilderTaskWrapper</returns>
        Task<DocumentBuilderTaskWrapper> GetCustomerOperationsReportAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the operations report status
        /// </summary>
        /// <remarks>
        /// Returns the state of the `xlsx` wallet operations report this user started with  `POST api/2.0/portal/payment/customer/operationsreport`: `percentage` while it is being built, `isCompleted`  when it is done, `resultFileId`, `resultFileName` and `resultFileUrl` pointing at the file in the caller's My  documents, and `error` when the build failed. The portal needs a billing customer and the caller has to be a  DocSpace administrator; the call is read-only and is the one to poll. The task is kept per user and per report  kind, so it never reports another administrator's report, nor the service usage and monthly usage ones, which  have their own status operations. An empty result means this user has no operations report at all - none was  started, or the finished one was already picked up or terminated. A completed task is dropped as soon as the  next report is started, so read the file link out of the same answer that first reports `isCompleted`.
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
        /// Returns how much of each wallet service the portal consumed and what that cost, added up per service instead  of listed per movement. Only a DocSpace administrator may read it, a portal with no billing customer answers  with an empty result, and the call is read-only. The filters are optional: `serviceName` narrows to particular  services and fails with 404 on a name this installation does not sell, `participantName` and `status` narrow  to who consumed and how the operation ended, `startDate` and `endDate` bound the period in the portal time  zone, `metadata` matches the key and value pairs a service records with its usage, and `offset`, `limit`,  `orderBy` and `orderType` page and sort the result. Amounts come with the unit the service is sold in, except  AI tools, whose consumption is reported in tokens rather than in AI credits. The individual charges behind  these totals are `GET api/2.0/portal/payment/customer/operations`, and the same figures as a downloadable file  are `POST api/2.0/portal/payment/customer/usage/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName">The wallet services whose consumption is added up, named the way the billing catalogue names them -  `backup`, `ai-tools`, `ai-search`, `disk-storage`, `docscloud`. Take the values from the `serviceName` field  of `GET api/2.0/portal/payment/walletservices`; the match ignores case, a name this installation does not  sell fails the call with 404, and an omitted list covers every service. (optional)</param>
        /// <param name="participantName">The participant whose consumption is added up - the account the accounting service records as the consumer.  Consumption caused by a portal user carries that user ID here; surrounding whitespace is trimmed, and an  omitted value covers every participant. (optional)</param>
        /// <param name="status">The outcome to keep. Consumption that is still being settled is reported as pending and may change later,  while the other outcomes are final; every outcome is counted when this is omitted. (optional)</param>
        /// <param name="startDate">The beginning of the reported period, inclusive. Read in the portal time zone rather than in UTC, and  defaults to the portal creation date. (optional)</param>
        /// <param name="endDate">The end of the reported period, inclusive. Read in the portal time zone rather than in UTC, and defaults to  the moment the call is made. (optional)</param>
        /// <param name="metadata">The usage annotations a wallet service records alongside its consumption, as the key and value pairs that  must all match for a record to be counted. The keys are chosen by the service that writes them, so read them  off the `metadata` of the records already returned rather than guessing; an omitted map counts every record. (optional)</param>
        /// <param name="offset">The number of per-service totals to skip before the first one returned. Counted after the filters and the  ordering are applied, and starts at 0 when omitted. (optional)</param>
        /// <param name="limit">The maximum number of per-service totals returned in one page. Defaults to 25 when omitted; the answer echoes  the window back with its paging information, so the next `offset` can be computed without counting the items. (optional)</param>
        /// <param name="orderBy">The name of the field the per-service totals are sorted by, spelled as the accounting service names it, such  as `ServiceName` or `StartDate`. Surrounding whitespace is trimmed, and the accounting service applies its  own ordering when this is omitted. (optional)</param>
        /// <param name="orderType">The direction the field named in `orderBy` is sorted in. Newest or largest first is what the accounting  service does by default, so leaving this out sorts the same way as asking for descending explicitly. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-service-usage/">REST API Reference for GetCustomerServiceUsage Operation</seealso>
        /// <returns>Task of CustomerServiceUsageReportWrapper</returns>
        Task<CustomerServiceUsageReportWrapper> GetCustomerServiceUsageAsync(List<string>? serviceName = default, string? participantName = default, OperationStatus? status = default, DateTime? startDate = default, DateTime? endDate = default, Dictionary<string, string>? metadata = default, int? offset = default, int? limit = default, string? orderBy = default, OperationOrderType? orderType = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the customer service usage
        /// </summary>
        /// <remarks>
        /// Returns how much of each wallet service the portal consumed and what that cost, added up per service instead  of listed per movement. Only a DocSpace administrator may read it, a portal with no billing customer answers  with an empty result, and the call is read-only. The filters are optional: `serviceName` narrows to particular  services and fails with 404 on a name this installation does not sell, `participantName` and `status` narrow  to who consumed and how the operation ended, `startDate` and `endDate` bound the period in the portal time  zone, `metadata` matches the key and value pairs a service records with its usage, and `offset`, `limit`,  `orderBy` and `orderType` page and sort the result. Amounts come with the unit the service is sold in, except  AI tools, whose consumption is reported in tokens rather than in AI credits. The individual charges behind  these totals are `GET api/2.0/portal/payment/customer/operations`, and the same figures as a downloadable file  are `POST api/2.0/portal/payment/customer/usage/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName">The wallet services whose consumption is added up, named the way the billing catalogue names them -  `backup`, `ai-tools`, `ai-search`, `disk-storage`, `docscloud`. Take the values from the `serviceName` field  of `GET api/2.0/portal/payment/walletservices`; the match ignores case, a name this installation does not  sell fails the call with 404, and an omitted list covers every service. (optional)</param>
        /// <param name="participantName">The participant whose consumption is added up - the account the accounting service records as the consumer.  Consumption caused by a portal user carries that user ID here; surrounding whitespace is trimmed, and an  omitted value covers every participant. (optional)</param>
        /// <param name="status">The outcome to keep. Consumption that is still being settled is reported as pending and may change later,  while the other outcomes are final; every outcome is counted when this is omitted. (optional)</param>
        /// <param name="startDate">The beginning of the reported period, inclusive. Read in the portal time zone rather than in UTC, and  defaults to the portal creation date. (optional)</param>
        /// <param name="endDate">The end of the reported period, inclusive. Read in the portal time zone rather than in UTC, and defaults to  the moment the call is made. (optional)</param>
        /// <param name="metadata">The usage annotations a wallet service records alongside its consumption, as the key and value pairs that  must all match for a record to be counted. The keys are chosen by the service that writes them, so read them  off the `metadata` of the records already returned rather than guessing; an omitted map counts every record. (optional)</param>
        /// <param name="offset">The number of per-service totals to skip before the first one returned. Counted after the filters and the  ordering are applied, and starts at 0 when omitted. (optional)</param>
        /// <param name="limit">The maximum number of per-service totals returned in one page. Defaults to 25 when omitted; the answer echoes  the window back with its paging information, so the next `offset` can be computed without counting the items. (optional)</param>
        /// <param name="orderBy">The name of the field the per-service totals are sorted by, spelled as the accounting service names it, such  as `ServiceName` or `StartDate`. Surrounding whitespace is trimmed, and the accounting service applies its  own ordering when this is omitted. (optional)</param>
        /// <param name="orderType">The direction the field named in `orderBy` is sorted in. Newest or largest first is what the accounting  service does by default, so leaving this out sorts the same way as asking for descending explicitly. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-service-usage/">REST API Reference for GetCustomerServiceUsage Operation</seealso>
        /// <returns>Task of ApiResponse (CustomerServiceUsageReportWrapper)</returns>
        Task<ApiResponse<CustomerServiceUsageReportWrapper>> GetCustomerServiceUsageWithHttpInfoAsync(List<string>? serviceName = default, string? participantName = default, OperationStatus? status = default, DateTime? startDate = default, DateTime? endDate = default, Dictionary<string, string>? metadata = default, int? offset = default, int? limit = default, string? orderBy = default, OperationOrderType? orderType = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the service usage report status
        /// </summary>
        /// <remarks>
        /// Returns the state of the `xlsx` service usage report this user started with  `POST api/2.0/portal/payment/customer/usage/report`: `percentage` while it is being built, `isCompleted` when  it is done, `resultFileId`, `resultFileName` and `resultFileUrl` pointing at the file in the caller's My  documents, and `error` when the build failed. The portal needs a billing customer and the caller has to be a  DocSpace administrator; the call is read-only and is the one to poll. The task is kept per user and per report  kind, so it reports neither another administrator's report nor the operations and monthly usage ones, which  have their own status operations. An empty result means this user has no service usage report at all - none  was started, or the finished one was already picked up or terminated. A completed task is dropped as soon as  the next report is started, so read the file link out of the same answer that first reports `isCompleted`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-service-usage-report/">REST API Reference for GetCustomerServiceUsageReport Operation</seealso>
        /// <returns>Task of DocumentBuilderTaskWrapper</returns>
        Task<DocumentBuilderTaskWrapper> GetCustomerServiceUsageReportAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the service usage report status
        /// </summary>
        /// <remarks>
        /// Returns the state of the `xlsx` service usage report this user started with  `POST api/2.0/portal/payment/customer/usage/report`: `percentage` while it is being built, `isCompleted` when  it is done, `resultFileId`, `resultFileName` and `resultFileUrl` pointing at the file in the caller's My  documents, and `error` when the build failed. The portal needs a billing customer and the caller has to be a  DocSpace administrator; the call is read-only and is the one to poll. The task is kept per user and per report  kind, so it reports neither another administrator's report nor the operations and monthly usage ones, which  have their own status operations. An empty result means this user has no service usage report at all - none  was started, or the finished one was already picked up or terminated. A completed task is dropped as soon as  the next report is started, so read the file link out of the same answer that first reports `isCompleted`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-service-usage-report/">REST API Reference for GetCustomerServiceUsageReport Operation</seealso>
        /// <returns>Task of ApiResponse (DocumentBuilderTaskWrapper)</returns>
        Task<ApiResponse<DocumentBuilderTaskWrapper>> GetCustomerServiceUsageReportWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the billing account page
        /// </summary>
        /// <remarks>
        /// Hands back the address of the portal page on which the billing account is managed - the payment method on  file, the invoices and the receipts - so a client can link to it instead of assembling the address itself. The  portal must already have a billing customer: one that has never had it gets an empty result, and an  installation without a billing service answers 403. Only the payer or the portal owner may read it, and the  call changes nothing. The value is relative to the portal root (`payment.ashx`), and the optional `backUrl` is  appended to it as a query parameter so the page can send the user back where they came from. It is not a  checkout page: a plan is bought with `PUT api/2.0/portal/payment/url` and a payment method is attached with  `GET api/2.0/portal/payment/checkoutsetupurl`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">The absolute address the billing account page should offer as its way back. It is appended to the returned  portal-relative address as a query parameter rather than followed here, and omitting it yields the bare  address of the page. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-account/">REST API Reference for GetPaymentAccount Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        Task<StringWrapper> GetPaymentAccountAsync(string? backUrl = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the billing account page
        /// </summary>
        /// <remarks>
        /// Hands back the address of the portal page on which the billing account is managed - the payment method on  file, the invoices and the receipts - so a client can link to it instead of assembling the address itself. The  portal must already have a billing customer: one that has never had it gets an empty result, and an  installation without a billing service answers 403. Only the payer or the portal owner may read it, and the  call changes nothing. The value is relative to the portal root (`payment.ashx`), and the optional `backUrl` is  appended to it as a query parameter so the page can send the user back where they came from. It is not a  checkout page: a plan is bought with `PUT api/2.0/portal/payment/url` and a payment method is attached with  `GET api/2.0/portal/payment/checkoutsetupurl`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">The absolute address the billing account page should offer as its way back. It is appended to the returned  portal-relative address as a query parameter rather than followed here, and omitting it yields the bare  address of the page. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-account/">REST API Reference for GetPaymentAccount Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        Task<ApiResponse<StringWrapper>> GetPaymentAccountWithHttpInfoAsync(string? backUrl = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the billing currencies
        /// </summary>
        /// <remarks>
        /// Tells a client which currency the portal is billed in: the default currency of the portal region always comes  first, followed by the currency resolved for the current request when that one differs, so the answer holds  one or two items. Nothing has to be called first, the caller needs the permission to edit the portal settings,  and the call is read-only. Each item carries the country code of the region, the currency symbol and the  native name of the currency; the first item is the currency the amounts from  `GET api/2.0/portal/payment/prices` are expressed in. These are the currencies of the subscription prices, and  they are not the accounting currencies the wallet is topped up in - those come with the balance in  `GET api/2.0/portal/payment/customer/balance`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-currencies/">REST API Reference for GetPaymentCurrencies Operation</seealso>
        /// <returns>Task of CurrenciesArrayWrapper</returns>
        Task<CurrenciesArrayWrapper> GetPaymentCurrenciesAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the billing currencies
        /// </summary>
        /// <remarks>
        /// Tells a client which currency the portal is billed in: the default currency of the portal region always comes  first, followed by the currency resolved for the current request when that one differs, so the answer holds  one or two items. Nothing has to be called first, the caller needs the permission to edit the portal settings,  and the call is read-only. Each item carries the country code of the region, the currency symbol and the  native name of the currency; the first item is the currency the amounts from  `GET api/2.0/portal/payment/prices` are expressed in. These are the currencies of the subscription prices, and  they are not the accounting currencies the wallet is topped up in - those come with the balance in  `GET api/2.0/portal/payment/customer/balance`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-currencies/">REST API Reference for GetPaymentCurrencies Operation</seealso>
        /// <returns>Task of ApiResponse (CurrenciesArrayWrapper)</returns>
        Task<ApiResponse<CurrenciesArrayWrapper>> GetPaymentCurrenciesWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the purchasable quotas
        /// </summary>
        /// <remarks>
        /// Lists the quotas the portal can be put on - the paid plans and the wallet services - each with its price, its  features and the limits it grants, which is what a pricing page is built from. Nothing has to be called first,  the caller needs the permission to edit the portal settings, and the call is read-only. Only quotas marked  visible are listed, newest first, and the two optional filters narrow that: `wallet` selects the wallet  services (`true`) or the subscription plans (`false`), `additional` selects the add-ons to a plan (`true`) or  the plans themselves (`false`), and an omitted filter keeps both kinds. A portal on a non-profit quota is a  special case - asking for `additional=false` returns that single quota and nothing else, because no other plan  may be bought for it. The quota the portal is actually on is not marked here; read it from  `GET api/2.0/portal/payment/quota`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wallet">Which side of the catalogue is listed: `true` keeps the services paid out of the portal wallet, `false` keeps  the subscription plans, and omitting it keeps both. (optional)</param>
        /// <param name="additional">Which layer of the catalogue is listed: `true` keeps the add-ons that extend a plan, `false` keeps the plans  themselves, and omitting it keeps both. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-quotas/">REST API Reference for GetPaymentQuotas Operation</seealso>
        /// <returns>Task of QuotaArrayWrapper</returns>
        Task<QuotaArrayWrapper> GetPaymentQuotasAsync(bool? wallet = default, bool? additional = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the purchasable quotas
        /// </summary>
        /// <remarks>
        /// Lists the quotas the portal can be put on - the paid plans and the wallet services - each with its price, its  features and the limits it grants, which is what a pricing page is built from. Nothing has to be called first,  the caller needs the permission to edit the portal settings, and the call is read-only. Only quotas marked  visible are listed, newest first, and the two optional filters narrow that: `wallet` selects the wallet  services (`true`) or the subscription plans (`false`), `additional` selects the add-ons to a plan (`true`) or  the plans themselves (`false`), and an omitted filter keeps both kinds. A portal on a non-profit quota is a  special case - asking for `additional=false` returns that single quota and nothing else, because no other plan  may be bought for it. The quota the portal is actually on is not marked here; read it from  `GET api/2.0/portal/payment/quota`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wallet">Which side of the catalogue is listed: `true` keeps the services paid out of the portal wallet, `false` keeps  the subscription plans, and omitting it keeps both. (optional)</param>
        /// <param name="additional">Which layer of the catalogue is listed: `true` keeps the add-ons that extend a plan, `false` keeps the plans  themselves, and omitting it keeps both. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-quotas/">REST API Reference for GetPaymentQuotas Operation</seealso>
        /// <returns>Task of ApiResponse (QuotaArrayWrapper)</returns>
        Task<ApiResponse<QuotaArrayWrapper>> GetPaymentQuotasWithHttpInfoAsync(bool? wallet = default, bool? additional = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the payment page URL
        /// </summary>
        /// <remarks>
        /// Starts the purchase of a monthly paid plan for this portal by handing back the hosted checkout page the buyer  has to open; nothing is bought until that page is completed. The portal must have no paid plan yet - a portal  whose plan is already paid gets an empty result and changes its subscription through  `PUT api/2.0/portal/payment/update` instead - and the product name in `quantity` must be one of the monthly,  non-wallet plans listed by `GET api/2.0/portal/payment/quotas`. Only a DocSpace administrator may call it. The  call itself changes nothing on the portal and may be repeated: the money is taken by the payment provider on  the checkout page, and the plan becomes active once the provider confirms it. The returned URL is absolute and  single-purpose - it carries the caller's e-mail, the language of the request and the currency of the request  region, and it redirects to `successUrl` or `backUrl` when the buyer finishes or cancels. Exactly one product  per call is accepted and its quantity has to be greater than zero; yearly and wallet products are refused, and  wallet services are bought with `PUT api/2.0/portal/payment/updatewallet` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentUrlRequestDto">The plan being bought and the two pages the hosted checkout returns the buyer to. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-url/">REST API Reference for GetPaymentUrl Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        Task<StringWrapper> GetPaymentUrlAsync(PaymentUrlRequestDto? paymentUrlRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the payment page URL
        /// </summary>
        /// <remarks>
        /// Starts the purchase of a monthly paid plan for this portal by handing back the hosted checkout page the buyer  has to open; nothing is bought until that page is completed. The portal must have no paid plan yet - a portal  whose plan is already paid gets an empty result and changes its subscription through  `PUT api/2.0/portal/payment/update` instead - and the product name in `quantity` must be one of the monthly,  non-wallet plans listed by `GET api/2.0/portal/payment/quotas`. Only a DocSpace administrator may call it. The  call itself changes nothing on the portal and may be repeated: the money is taken by the payment provider on  the checkout page, and the plan becomes active once the provider confirms it. The returned URL is absolute and  single-purpose - it carries the caller's e-mail, the language of the request and the currency of the request  region, and it redirects to `successUrl` or `backUrl` when the buyer finishes or cancels. Exactly one product  per call is accepted and its quantity has to be greater than zero; yearly and wallet products are refused, and  wallet services are bought with `PUT api/2.0/portal/payment/updatewallet` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentUrlRequestDto">The plan being bought and the two pages the hosted checkout returns the buyer to. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-url/">REST API Reference for GetPaymentUrl Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        Task<ApiResponse<StringWrapper>> GetPaymentUrlWithHttpInfoAsync(PaymentUrlRequestDto? paymentUrlRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the product prices
        /// </summary>
        /// <remarks>
        /// Lists what one unit of every purchasable product costs, keyed by the product name that `quantity` takes in the  purchase operations, so a client can price a plan or a wallet service without reading the whole quota list.  Nothing has to be called first, and the caller needs the permission to edit the portal settings, which portal  administrators and the owner have. The call is read-only. Prices are given in the one currency resolved for  this request from the portal region, which `GET api/2.0/portal/payment/currencies` reports; a product with no  price in that currency comes back as `0` rather than being left out, so a zero means unpriced and not free.  The list covers the products on offer, not the portal's own plan - the plan in force, with its limits and its  usage, is `GET api/2.0/portal/payment/quota`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-prices/">REST API Reference for GetPortalPrices Operation</seealso>
        /// <returns>Task of GetPortalPrices200Response</returns>
        Task<GetPortalPrices200Response> GetPortalPricesAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the product prices
        /// </summary>
        /// <remarks>
        /// Lists what one unit of every purchasable product costs, keyed by the product name that `quantity` takes in the  purchase operations, so a client can price a plan or a wallet service without reading the whole quota list.  Nothing has to be called first, and the caller needs the permission to edit the portal settings, which portal  administrators and the owner have. The call is read-only. Prices are given in the one currency resolved for  this request from the portal region, which `GET api/2.0/portal/payment/currencies` reports; a product with no  price in that currency comes back as `0` rather than being left out, so a zero means unpriced and not free.  The list covers the products on offer, not the portal's own plan - the plan in force, with its limits and its  usage, is `GET api/2.0/portal/payment/quota`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-prices/">REST API Reference for GetPortalPrices Operation</seealso>
        /// <returns>Task of ApiResponse (GetPortalPrices200Response)</returns>
        Task<ApiResponse<GetPortalPrices200Response>> GetPortalPricesWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the current plan and limits
        /// </summary>
        /// <remarks>
        /// Returns the quota the portal is on right now - its paid plan or the free one - with everything a client needs  to render itself: the price, the features that are switched on, the limits they grant (rooms, storage in  bytes, users, administrators, AI) and how much of each is already used. Every signed-in member of the portal  reads it, so it is not restricted to administrators; only guests are refused with 403. The call is read-only.  The plan is served from the cache by default, which is what a start-up needs; `refresh=true` fetches it from  the billing service instead, so use that right after a purchase and not routinely, because it is a remote  call. The catalogue of the quotas that could be bought instead is `GET api/2.0/portal/payment/quotas`, and the  money side of the same portal - customer, wallet and balance - starts at  `GET api/2.0/portal/payment/customerinfo`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Whether the answer is fetched from the billing service instead of the portal cache. The cached copy is what a  start-up needs and costs nothing; asking for a fresh one makes a remote call, so use it right after a  purchase or a top-up and not on every read. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-quota-payment-information/">REST API Reference for GetQuotaPaymentInformation Operation</seealso>
        /// <returns>Task of QuotaWrapper</returns>
        Task<QuotaWrapper> GetQuotaPaymentInformationAsync(bool? refresh = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the current plan and limits
        /// </summary>
        /// <remarks>
        /// Returns the quota the portal is on right now - its paid plan or the free one - with everything a client needs  to render itself: the price, the features that are switched on, the limits they grant (rooms, storage in  bytes, users, administrators, AI) and how much of each is already used. Every signed-in member of the portal  reads it, so it is not restricted to administrators; only guests are refused with 403. The call is read-only.  The plan is served from the cache by default, which is what a start-up needs; `refresh=true` fetches it from  the billing service instead, so use that right after a purchase and not routinely, because it is a remote  call. The catalogue of the quotas that could be bought instead is `GET api/2.0/portal/payment/quotas`, and the  money side of the same portal - customer, wallet and balance - starts at  `GET api/2.0/portal/payment/customerinfo`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Whether the answer is fetched from the billing service instead of the portal cache. The cached copy is what a  start-up needs and costs nothing; asking for a fresh one makes a remote call, so use it right after a  purchase or a top-up and not on every read. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-quota-payment-information/">REST API Reference for GetQuotaPaymentInformation Operation</seealso>
        /// <returns>Task of ApiResponse (QuotaWrapper)</returns>
        Task<ApiResponse<QuotaWrapper>> GetQuotaPaymentInformationWithHttpInfoAsync(bool? refresh = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get restricted AI models
        /// </summary>
        /// <remarks>
        /// Returns the AI chat models that are barred on this portal - the ones no user of it may pick for a  conversation, whatever the price list offers. Only a DocSpace administrator may read it, and the call is  read-only. When the installation has no billing service or AI is not enabled for the portal, the answer is an  empty set instead of an error, which is indistinguishable from a portal that restricts nothing. An empty  `models` therefore means every model in `GET api/2.0/portal/payment/ai-prices` may be used. The set names the  barred models and not the allowed ones; replace it with `PUT api/2.0/portal/payment/ai-model/restrictions`.
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
        /// Returns the AI chat models that are barred on this portal - the ones no user of it may pick for a  conversation, whatever the price list offers. Only a DocSpace administrator may read it, and the call is  read-only. When the installation has no billing service or AI is not enabled for the portal, the answer is an  empty set instead of an error, which is indistinguishable from a portal that restricts nothing. An empty  `models` therefore means every model in `GET api/2.0/portal/payment/ai-prices` may be used. The set names the  barred models and not the allowed ones; replace it with `PUT api/2.0/portal/payment/ai-model/restrictions`.
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
        /// Reports in money how much of the portal's paid subscription period is still unused - the credit that  `POST api/2.0/portal/payment/subscription/movetowallet` would carry over to the wallet if the subscription  were ended now. The portal must have a billing customer and a plan in the paid state; a plan that is not paid  answers 402, and a paid plan without a subscription row gives 404. Only the payer - the portal user whose  e-mail is the billing customer's e-mail - may read it, and the call is read-only. The answer states the total  cost of the current period with its currency, the start and the end of that period in UTC, the moment the  unused part is measured up to, the days already elapsed, and the remaining balance both in the subscription  currency and converted to the wallet currency. Every figure is computed for the instant of the request, so it  changes between calls.
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
        /// Reports in money how much of the portal's paid subscription period is still unused - the credit that  `POST api/2.0/portal/payment/subscription/movetowallet` would carry over to the wallet if the subscription  were ended now. The portal must have a billing customer and a plan in the paid state; a plan that is not paid  answers 402, and a paid plan without a subscription row gives 404. Only the payer - the portal user whose  e-mail is the billing customer's e-mail - may read it, and the call is read-only. The answer states the total  cost of the current period with its currency, the start and the end of that period in UTC, the moment the  unused part is measured up to, the days already elapsed, and the remaining balance both in the subscription  currency and converted to the wallet currency. Every figure is computed for the instant of the request, so it  changes between calls.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-subscription-balance-info/">REST API Reference for GetSubscriptionBalanceInfo Operation</seealso>
        /// <returns>Task of ApiResponse (SubscriptionBalanceInfoWrapper)</returns>
        Task<ApiResponse<SubscriptionBalanceInfoWrapper>> GetSubscriptionBalanceInfoWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the wallet service settings
        /// </summary>
        /// <remarks>
        /// Returns which wallet services an administrator has switched on for this portal by hand, as opposed to the ones  its plan pays for. Only a DocSpace administrator may read it, an installation without a billing service  answers 403, no billing customer is needed, and the call is read-only. `enabledServices` holds the names of  those services and is empty when none was switched on. This is the stored setting and not the state of the  portal: a service the plan brings with it is active without appearing here, so the honest answer to what is  running is `GET api/2.0/portal/payment/activeservices`. One entry is changed with  `POST api/2.0/portal/payment/servicestate`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-wallet-service-settings/">REST API Reference for GetTenantWalletServiceSettings Operation</seealso>
        /// <returns>Task of TenantWalletServiceSettingsWrapper</returns>
        Task<TenantWalletServiceSettingsWrapper> GetTenantWalletServiceSettingsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the wallet service settings
        /// </summary>
        /// <remarks>
        /// Returns which wallet services an administrator has switched on for this portal by hand, as opposed to the ones  its plan pays for. Only a DocSpace administrator may read it, an installation without a billing service  answers 403, no billing customer is needed, and the call is read-only. `enabledServices` holds the names of  those services and is empty when none was switched on. This is the stored setting and not the state of the  portal: a service the plan brings with it is active without appearing here, so the honest answer to what is  running is `GET api/2.0/portal/payment/activeservices`. One entry is changed with  `POST api/2.0/portal/payment/servicestate`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-wallet-service-settings/">REST API Reference for GetTenantWalletServiceSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantWalletServiceSettingsWrapper)</returns>
        Task<ApiResponse<TenantWalletServiceSettingsWrapper>> GetTenantWalletServiceSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the auto top-up settings
        /// </summary>
        /// <remarks>
        /// Returns the portal's automatic wallet top-up settings - whether it is on, the balance that triggers a  charge, the balance it is topped up to, and the currency both are expressed in. Any DocSpace  administrator may read them, and unlike the operation that changes them this one needs neither a  billing customer nor a configured billing service, so it answers on a portal that has never paid for  anything. It is read-only and changes nothing.  A portal that has never configured top-up gets the defaults rather than an empty result: `enabled` is  false, `currency` is null, and `minBalance` and `upToBalance` are 0. Those two zeros are outside the  ranges `POST api/2.0/portal/payment/topupsettings` accepts - 5 to 1000 and 6 to 5000 - so the answer  cannot be sent straight back to it; supply real values instead. `lastModified` is  `0001-01-01T00:00:00` until the settings are stored for the first time.  `lowBalanceThreshold` and `lowBalanceNotified` are maintained by the portal itself: they are reported  here, but ignored when the settings are written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-wallet-settings/">REST API Reference for GetTenantWalletSettings Operation</seealso>
        /// <returns>Task of TenantWalletSettingsResponseWrapper</returns>
        Task<TenantWalletSettingsResponseWrapper> GetTenantWalletSettingsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the auto top-up settings
        /// </summary>
        /// <remarks>
        /// Returns the portal's automatic wallet top-up settings - whether it is on, the balance that triggers a  charge, the balance it is topped up to, and the currency both are expressed in. Any DocSpace  administrator may read them, and unlike the operation that changes them this one needs neither a  billing customer nor a configured billing service, so it answers on a portal that has never paid for  anything. It is read-only and changes nothing.  A portal that has never configured top-up gets the defaults rather than an empty result: `enabled` is  false, `currency` is null, and `minBalance` and `upToBalance` are 0. Those two zeros are outside the  ranges `POST api/2.0/portal/payment/topupsettings` accepts - 5 to 1000 and 6 to 5000 - so the answer  cannot be sent straight back to it; supply real values instead. `lastModified` is  `0001-01-01T00:00:00` until the settings are stored for the first time.  `lowBalanceThreshold` and `lowBalanceNotified` are maintained by the portal itself: they are reported  here, but ignored when the settings are written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-wallet-settings/">REST API Reference for GetTenantWalletSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantWalletSettingsResponseWrapper)</returns>
        Task<ApiResponse<TenantWalletSettingsResponseWrapper>> GetTenantWalletSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a wallet service
        /// </summary>
        /// <remarks>
        /// Returns one wallet service by name, for a client that already knows which service it needs and does not want  the whole catalogue. `service` is the name of the service - `Storage`, `Backup`, `AITools`, `Admin`,  `DocsCloud`, `DocsCloudDevPack` or `AISearch` - and a name this installation does not sell answers 404.  Nothing has to be called first, the caller needs the permission to edit the portal settings, and the call is  read-only. The answer has the same shape as one item of `GET api/2.0/portal/payment/walletservices` - the  price of a unit, the unit, the limits the service grants and its service name - except that the variants of a  service are not grouped into `innerServices` here, because a single service is looked up directly. The price  is in the currency resolved for the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="service">The service to look up, given by its catalogue name. A service this installation does not sell answers 404,  and the whole catalogue is `GET api/2.0/portal/payment/walletservices`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-wallet-service/">REST API Reference for GetWalletService Operation</seealso>
        /// <returns>Task of WalletServiceWrapper</returns>
        Task<WalletServiceWrapper> GetWalletServiceAsync(TenantWalletService service, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a wallet service
        /// </summary>
        /// <remarks>
        /// Returns one wallet service by name, for a client that already knows which service it needs and does not want  the whole catalogue. `service` is the name of the service - `Storage`, `Backup`, `AITools`, `Admin`,  `DocsCloud`, `DocsCloudDevPack` or `AISearch` - and a name this installation does not sell answers 404.  Nothing has to be called first, the caller needs the permission to edit the portal settings, and the call is  read-only. The answer has the same shape as one item of `GET api/2.0/portal/payment/walletservices` - the  price of a unit, the unit, the limits the service grants and its service name - except that the variants of a  service are not grouped into `innerServices` here, because a single service is looked up directly. The price  is in the currency resolved for the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="service">The service to look up, given by its catalogue name. A service this installation does not sell answers 404,  and the whole catalogue is `GET api/2.0/portal/payment/walletservices`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-wallet-service/">REST API Reference for GetWalletService Operation</seealso>
        /// <returns>Task of ApiResponse (WalletServiceWrapper)</returns>
        Task<ApiResponse<WalletServiceWrapper>> GetWalletServiceWithHttpInfoAsync(TenantWalletService service, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get wallet services
        /// </summary>
        /// <remarks>
        /// Lists every service the portal may pay for out of its wallet - extra administrators, disk storage, backup, AI  tools, AI search and DocsCloud - with the price of a unit, the unit it is sold in and whether the portal has  it switched on. Nothing has to be called first, the caller needs the permission to edit the portal settings,  and the call is read-only. Services that are variants of one another are folded together: the visible one  carries the rest in its `innerServices`, so a client renders one card per group. The AI services are left out  entirely when AI is not enabled for the portal. This is the catalogue and not the state of the portal - what  is actually running is `GET api/2.0/portal/payment/activeservices`, one service on its own is  `GET api/2.0/portal/payment/walletservice`, and switching one on or off is  `POST api/2.0/portal/payment/servicestate`.
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
        /// Lists every service the portal may pay for out of its wallet - extra administrators, disk storage, backup, AI  tools, AI search and DocsCloud - with the price of a unit, the unit it is sold in and whether the portal has  it switched on. Nothing has to be called first, the caller needs the permission to edit the portal settings,  and the call is read-only. Services that are variants of one another are folded together: the visible one  carries the rest in its `innerServices`, so a client renders one card per group. The AI services are left out  entirely when AI is not enabled for the portal. This is the catalogue and not the state of the portal - what  is actually running is `GET api/2.0/portal/payment/activeservices`, one service on its own is  `GET api/2.0/portal/payment/walletservice`, and switching one on or off is  `POST api/2.0/portal/payment/servicestate`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-wallet-services/">REST API Reference for GetWalletServices Operation</seealso>
        /// <returns>Task of ApiResponse (WalletServiceArrayWrapper)</returns>
        Task<ApiResponse<WalletServiceArrayWrapper>> GetWalletServicesWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Move the subscription to the wallet
        /// </summary>
        /// <remarks>
        /// Ends the portal's paid subscription and moves it onto the wallet: the unused balance of the running period is  credited to the wallet, the wallet is topped up from the payment method on file if that credit does not cover  the purchase, and the requested number of administrators is then bought as a wallet service. The portal needs  a billing customer with a payment method set and a plan in the paid state, `quantity` has to name the  administrators wallet product, and the number asked for may not be below the administrators the portal already  has - read the credit that will be carried over from `GET api/2.0/portal/payment/subscription/balance` first.  Only the payer may call it. The call is mutating, spends money and cannot be undone: the subscription is ended  before the purchase is attempted, so a failure in the second half leaves the portal on the wallet with the  money credited but the administrators unbought, and a repeat would then buy them a second time. It is limited  to ten requests a minute per user by default. The result is `true` when the administrators were bought.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quantityRequestDto">The new size of the portal subscription. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-subscription-to-wallet/">REST API Reference for MoveSubscriptionToWallet Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        Task<BooleanWrapper> MoveSubscriptionToWalletAsync(QuantityRequestDto? quantityRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Move the subscription to the wallet
        /// </summary>
        /// <remarks>
        /// Ends the portal's paid subscription and moves it onto the wallet: the unused balance of the running period is  credited to the wallet, the wallet is topped up from the payment method on file if that credit does not cover  the purchase, and the requested number of administrators is then bought as a wallet service. The portal needs  a billing customer with a payment method set and a plan in the paid state, `quantity` has to name the  administrators wallet product, and the number asked for may not be below the administrators the portal already  has - read the credit that will be carried over from `GET api/2.0/portal/payment/subscription/balance` first.  Only the payer may call it. The call is mutating, spends money and cannot be undone: the subscription is ended  before the purchase is attempted, so a failure in the second half leaves the portal on the wallet with the  money credited but the administrators unbought, and a repeat would then buy them a second time. It is limited  to ten requests a minute per user by default. The result is `true` when the administrators were bought.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quantityRequestDto">The new size of the portal subscription. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-subscription-to-wallet/">REST API Reference for MoveSubscriptionToWallet Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        Task<ApiResponse<BooleanWrapper>> MoveSubscriptionToWalletWithHttpInfoAsync(QuantityRequestDto? quantityRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Contact the sales team
        /// </summary>
        /// <remarks>
        /// Sends the portal's message to the ONLYOFFICE sales team - the contact-sales form behind a request for a quote,  an invoice or a plan that cannot be bought online. `email` has to be a well-formed address and is where the  answer will go, while `userName` and `message` say who is asking and what for; all three are required and none  may be empty. Only a DocSpace administrator may call it. Nothing on the portal changes: no plan, no quota and  no payment is touched, a message is mailed out and the request is written to the portal audit trail. There is  no response body - status 200 means the message was handed to the mail service - and the call is not  idempotent, so a repeat sends a second message. It is limited to ten requests a minute per user by default and  answers 429 above that.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesRequestsDto">Who is writing to the ONLYOFFICE sales team, and what about. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-payment-request/">REST API Reference for SendPaymentRequest Operation</seealso>
        /// <returns>Task of void</returns>
        Task SendPaymentRequestAsync(SalesRequestsDto? salesRequestsDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Contact the sales team
        /// </summary>
        /// <remarks>
        /// Sends the portal's message to the ONLYOFFICE sales team - the contact-sales form behind a request for a quote,  an invoice or a plan that cannot be bought online. `email` has to be a well-formed address and is where the  answer will go, while `userName` and `message` say who is asking and what for; all three are required and none  may be empty. Only a DocSpace administrator may call it. Nothing on the portal changes: no plan, no quota and  no payment is touched, a message is mailed out and the request is written to the portal audit trail. There is  no response body - status 200 means the message was handed to the mail service - and the call is not  idempotent, so a repeat sends a second message. It is limited to ten requests a minute per user by default and  answers 429 above that.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesRequestsDto">Who is writing to the ONLYOFFICE sales team, and what about. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-payment-request/">REST API Reference for SendPaymentRequest Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> SendPaymentRequestWithHttpInfoAsync(SalesRequestsDto? salesRequestsDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Set restricted AI models
        /// </summary>
        /// <remarks>
        /// Replaces the whole set of AI chat models barred on this portal: the body is the complete set that is to hold,  so adding one restriction means sending the new model together with the ones already restricted, lifting one  means leaving it out, and an empty set lifts them all. Read the current set from  `GET api/2.0/portal/payment/ai-model/restrictions` and the model identifiers from  `GET api/2.0/portal/payment/ai-prices` before calling. The installation needs a billing service and the AI  gateway configured, the portal needs a billing customer, and the caller needs the permission to edit the  portal settings as well as DocSpace administrator rights. The call is mutating and idempotent - sending the  same set twice leaves the same state - and it is written to the portal audit trail. It takes effect on the  next AI request, so a conversation already open on a model that has just been barred cannot go on with it. The  stored set comes back in the answer.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setRestrictedAiModelsRequestDto">The complete set of AI chat models that are to be barred on the portal. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-restricted-ai-models/">REST API Reference for SetRestrictedAiModels Operation</seealso>
        /// <returns>Task of RestrictedModelsResponseWrapper</returns>
        Task<RestrictedModelsResponseWrapper> SetRestrictedAiModelsAsync(SetRestrictedAiModelsRequestDto? setRestrictedAiModelsRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Set restricted AI models
        /// </summary>
        /// <remarks>
        /// Replaces the whole set of AI chat models barred on this portal: the body is the complete set that is to hold,  so adding one restriction means sending the new model together with the ones already restricted, lifting one  means leaving it out, and an empty set lifts them all. Read the current set from  `GET api/2.0/portal/payment/ai-model/restrictions` and the model identifiers from  `GET api/2.0/portal/payment/ai-prices` before calling. The installation needs a billing service and the AI  gateway configured, the portal needs a billing customer, and the caller needs the permission to edit the  portal settings as well as DocSpace administrator rights. The call is mutating and idempotent - sending the  same set twice leaves the same state - and it is written to the portal audit trail. It takes effect on the  next AI request, so a conversation already open on a model that has just been barred cannot go on with it. The  stored set comes back in the answer.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setRestrictedAiModelsRequestDto">The complete set of AI chat models that are to be barred on the portal. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-restricted-ai-models/">REST API Reference for SetRestrictedAiModels Operation</seealso>
        /// <returns>Task of ApiResponse (RestrictedModelsResponseWrapper)</returns>
        Task<ApiResponse<RestrictedModelsResponseWrapper>> SetRestrictedAiModelsWithHttpInfoAsync(SetRestrictedAiModelsRequestDto? setRestrictedAiModelsRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Set the auto top-up settings
        /// </summary>
        /// <remarks>
        /// Switches the portal's automatic wallet top-up on or off and sets its thresholds: while it is on, the payment  method on file is charged whenever the wallet balance falls below `minBalance`, enough to bring it up to  `upToBalance`, in `currency`. The portal needs a billing customer whose wallet balance exists - a portal that  has never had one answers 404, so top the wallet up once with `POST api/2.0/portal/payment/deposit` first -  and only the payer may change the settings. The body replaces the stored settings as a whole and an omitted  body resets them to the defaults; `minBalance` is accepted between 5 and 1000 and `upToBalance` between 6 and  5000, while `lowBalanceThreshold` and `lowBalanceNotified` are ignored on the way in and kept as the portal  had them. The call is mutating and idempotent, it charges nothing by itself, it is written to the portal audit  trail, and switching the top-up on also re-arms the low-balance warning. The settings as they were stored come  back in the answer.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantWalletSettingsWrapper">The wrapper for the tenant wallet settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tenant-wallet-settings/">REST API Reference for SetTenantWalletSettings Operation</seealso>
        /// <returns>Task of TenantWalletSettingsResponseWrapper</returns>
        Task<TenantWalletSettingsResponseWrapper> SetTenantWalletSettingsAsync(TenantWalletSettingsWrapper? tenantWalletSettingsWrapper = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Set the auto top-up settings
        /// </summary>
        /// <remarks>
        /// Switches the portal's automatic wallet top-up on or off and sets its thresholds: while it is on, the payment  method on file is charged whenever the wallet balance falls below `minBalance`, enough to bring it up to  `upToBalance`, in `currency`. The portal needs a billing customer whose wallet balance exists - a portal that  has never had one answers 404, so top the wallet up once with `POST api/2.0/portal/payment/deposit` first -  and only the payer may change the settings. The body replaces the stored settings as a whole and an omitted  body resets them to the defaults; `minBalance` is accepted between 5 and 1000 and `upToBalance` between 6 and  5000, while `lowBalanceThreshold` and `lowBalanceNotified` are ignored on the way in and kept as the portal  had them. The call is mutating and idempotent, it charges nothing by itself, it is written to the portal audit  trail, and switching the top-up on also re-arms the low-balance warning. The settings as they were stored come  back in the answer.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantWalletSettingsWrapper">The wrapper for the tenant wallet settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tenant-wallet-settings/">REST API Reference for SetTenantWalletSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantWalletSettingsResponseWrapper)</returns>
        Task<ApiResponse<TenantWalletSettingsResponseWrapper>> SetTenantWalletSettingsWithHttpInfoAsync(TenantWalletSettingsWrapper? tenantWalletSettingsWrapper = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Terminate the monthly usage report
        /// </summary>
        /// <remarks>
        /// Stops the `xlsx` monthly usage report this user has running and drops its task, for a report that was started  for the wrong period or is no longer wanted. The portal needs a billing customer and the caller has to be a  DocSpace administrator. The stop is asked of the worker that builds the file rather than done here, so  `GET api/2.0/portal/payment/customer/usage/monthly/report` can still answer for a moment afterwards. The call  is safe to repeat and does nothing at all when this user has no such report running: there is no response  body, and status 200 says the stop was requested, not that a report was really stopped. It leaves the  operations and service usage reports alone, and a report that had already finished keeps its file in My  documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-monthly-usage-report/">REST API Reference for TerminateCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>Task of void</returns>
        Task TerminateCustomerMonthlyUsageReportAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Terminate the monthly usage report
        /// </summary>
        /// <remarks>
        /// Stops the `xlsx` monthly usage report this user has running and drops its task, for a report that was started  for the wrong period or is no longer wanted. The portal needs a billing customer and the caller has to be a  DocSpace administrator. The stop is asked of the worker that builds the file rather than done here, so  `GET api/2.0/portal/payment/customer/usage/monthly/report` can still answer for a moment afterwards. The call  is safe to repeat and does nothing at all when this user has no such report running: there is no response  body, and status 200 says the stop was requested, not that a report was really stopped. It leaves the  operations and service usage reports alone, and a report that had already finished keeps its file in My  documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-monthly-usage-report/">REST API Reference for TerminateCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> TerminateCustomerMonthlyUsageReportWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Terminate the operations report
        /// </summary>
        /// <remarks>
        /// Stops the `xlsx` wallet operations report this user has running and drops its task, for a report that was  started with the wrong filters or is no longer wanted. The portal needs a billing customer and the caller has  to be a DocSpace administrator. The stop is asked of the worker that builds the file rather than done here, so  `GET api/2.0/portal/payment/customer/operationsreport` can still answer for a moment afterwards. The call is  safe to repeat and does nothing at all when this user has no report running: there is no response body, and  status 200 says the stop was requested, not that a report was really stopped. A report that had already  finished keeps its file in My documents - nothing is deleted from there.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-operations-report/">REST API Reference for TerminateCustomerOperationsReport Operation</seealso>
        /// <returns>Task of void</returns>
        Task TerminateCustomerOperationsReportAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Terminate the operations report
        /// </summary>
        /// <remarks>
        /// Stops the `xlsx` wallet operations report this user has running and drops its task, for a report that was  started with the wrong filters or is no longer wanted. The portal needs a billing customer and the caller has  to be a DocSpace administrator. The stop is asked of the worker that builds the file rather than done here, so  `GET api/2.0/portal/payment/customer/operationsreport` can still answer for a moment afterwards. The call is  safe to repeat and does nothing at all when this user has no report running: there is no response body, and  status 200 says the stop was requested, not that a report was really stopped. A report that had already  finished keeps its file in My documents - nothing is deleted from there.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-operations-report/">REST API Reference for TerminateCustomerOperationsReport Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> TerminateCustomerOperationsReportWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Terminate the service usage report
        /// </summary>
        /// <remarks>
        /// Stops the `xlsx` service usage report this user has running and drops its task, for a report that was started  with the wrong filters or is no longer wanted. The portal needs a billing customer and the caller has to be a  DocSpace administrator. The stop is asked of the worker that builds the file rather than done here, so  `GET api/2.0/portal/payment/customer/usage/report` can still answer for a moment afterwards. The call is safe  to repeat and does nothing at all when this user has no such report running: there is no response body, and  status 200 says the stop was requested, not that a report was really stopped. It leaves the operations and  monthly usage reports alone, and a report that had already finished keeps its file in My documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-service-usage-report/">REST API Reference for TerminateCustomerServiceUsageReport Operation</seealso>
        /// <returns>Task of void</returns>
        Task TerminateCustomerServiceUsageReportAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Terminate the service usage report
        /// </summary>
        /// <remarks>
        /// Stops the `xlsx` service usage report this user has running and drops its task, for a report that was started  with the wrong filters or is no longer wanted. The portal needs a billing customer and the caller has to be a  DocSpace administrator. The stop is asked of the worker that builds the file rather than done here, so  `GET api/2.0/portal/payment/customer/usage/report` can still answer for a moment afterwards. The call is safe  to repeat and does nothing at all when this user has no such report running: there is no response body, and  status 200 says the stop was requested, not that a report was really stopped. It leaves the operations and  monthly usage reports alone, and a report that had already finished keeps its file in My documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-service-usage-report/">REST API Reference for TerminateCustomerServiceUsageReport Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> TerminateCustomerServiceUsageReportWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Top up the wallet
        /// </summary>
        /// <remarks>
        /// Charges the payment method on file and adds the amount to the portal's wallet, the balance every wallet  service is paid from. The portal needs a billing customer with a payment method set - attach one with  `GET api/2.0/portal/payment/checkoutsetupurl` - `currency` has to be one of the accounting currencies this  installation supports, and `amount` is a whole number of currency units between 1 and 999999. Only the payer  may call it. The call takes money and is not idempotent in any way: two identical requests charge twice, so a  client must not retry it blindly after a timeout, and it is limited to ten requests a minute per user by  default. A successful top-up pushes the new balance to the portal clients over their socket connection and  re-arms the low-balance notification. The result is `true` when the payment provider accepted the charge; read  the resulting balance back from `GET api/2.0/portal/payment/customer/balance`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topUpDepositRequestDto">How much money is charged to the payment method on file and added to the portal wallet. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/top-up-deposit/">REST API Reference for TopUpDeposit Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        Task<BooleanWrapper> TopUpDepositAsync(TopUpDepositRequestDto? topUpDepositRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Top up the wallet
        /// </summary>
        /// <remarks>
        /// Charges the payment method on file and adds the amount to the portal's wallet, the balance every wallet  service is paid from. The portal needs a billing customer with a payment method set - attach one with  `GET api/2.0/portal/payment/checkoutsetupurl` - `currency` has to be one of the accounting currencies this  installation supports, and `amount` is a whole number of currency units between 1 and 999999. Only the payer  may call it. The call takes money and is not idempotent in any way: two identical requests charge twice, so a  client must not retry it blindly after a timeout, and it is limited to ten requests a minute per user by  default. A successful top-up pushes the new balance to the portal clients over their socket connection and  re-arms the low-balance notification. The result is `true` when the payment provider accepted the charge; read  the resulting balance back from `GET api/2.0/portal/payment/customer/balance`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topUpDepositRequestDto">How much money is charged to the payment method on file and added to the portal wallet. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/top-up-deposit/">REST API Reference for TopUpDeposit Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        Task<ApiResponse<BooleanWrapper>> TopUpDepositWithHttpInfoAsync(TopUpDepositRequestDto? topUpDepositRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Change the subscription quantity
        /// </summary>
        /// <remarks>
        /// Changes how many units of the plan the portal is paying for - the number of administrators it covers - and  lets the payment provider bill the difference against the payment method already on file. The portal must have  a billing customer and a plan bought through `PUT api/2.0/portal/payment/url`, and while the portal is on a  priced plan the product name in `quantity` has to be that same plan, which `GET api/2.0/portal/payment/quota`  reports, because a subscription is changed here and not swapped. Only the payer - the portal user whose e-mail  is the billing customer's e-mail - may call it. The call is mutating and charges money, and it is guarded  against a double submission: once the new quantity is in effect, repeating the same request fails with 400  because that quantity is already set. The result is `true` when the provider accepted the change and `false`  when it declined it without an error. Exactly one product per call is accepted, the operation is limited to  ten requests a minute per user by default and answers 429 above that, and wallet services are not bought here  - use `PUT api/2.0/portal/payment/updatewallet` for those.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quantityRequestDto">The new size of the portal subscription. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-payment/">REST API Reference for UpdatePayment Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        Task<BooleanWrapper> UpdatePaymentAsync(QuantityRequestDto? quantityRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Change the subscription quantity
        /// </summary>
        /// <remarks>
        /// Changes how many units of the plan the portal is paying for - the number of administrators it covers - and  lets the payment provider bill the difference against the payment method already on file. The portal must have  a billing customer and a plan bought through `PUT api/2.0/portal/payment/url`, and while the portal is on a  priced plan the product name in `quantity` has to be that same plan, which `GET api/2.0/portal/payment/quota`  reports, because a subscription is changed here and not swapped. Only the payer - the portal user whose e-mail  is the billing customer's e-mail - may call it. The call is mutating and charges money, and it is guarded  against a double submission: once the new quantity is in effect, repeating the same request fails with 400  because that quantity is already set. The result is `true` when the provider accepted the change and `false`  when it declined it without an error. Exactly one product per call is accepted, the operation is limited to  ten requests a minute per user by default and answers 429 above that, and wallet services are not bought here  - use `PUT api/2.0/portal/payment/updatewallet` for those.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quantityRequestDto">The new size of the portal subscription. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-payment/">REST API Reference for UpdatePayment Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        Task<ApiResponse<BooleanWrapper>> UpdatePaymentWithHttpInfoAsync(QuantityRequestDto? quantityRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Change a wallet service quantity
        /// </summary>
        /// <remarks>
        /// Buys more units of a wallet service - extra administrators, disk storage, backup, AI tools, AI search or  DocsCloud - or writes down the quantity that service will have after the next renewal, depending on  `productQuantityType`. With `Add` (1) the units are bought at once and paid out of the portal wallet, so the  wallet needs a sub-account in the accounting currency and enough money on it; with `Set` (0) nothing is  charged now and the quantity only takes effect in the next period, where an empty or zero quantity cancels a  change scheduled earlier. `Renew` and `Sub` are not accepted here. The portal needs a billing customer and the  caller has to be a DocSpace administrator; a service that is an add-on to the plan also needs the plan itself  to be paid, otherwise the answer is 402. Minimum quantities apply - disk storage starts at 100 units, the  DocsCloud developer pack at 10, and the administrators may not be fewer than the portal already has - and in  the `Add` form they are checked only while the portal does not hold that service yet. Asking for the DocsCloud  plan in the `Set` form while the developer pack is active schedules the reversion to it at the next period,  while the upgrade in the other direction is not done here at all: use  `POST api/2.0/settings/docscloud/switchtodevpack`. The result is `true` when the change was accepted; the call  is mutating, spends money in its `Add` form and is limited to ten requests a minute per user by default. Price  the same purchase without paying for it with `PUT api/2.0/portal/payment/calculatewallet`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The wallet service being bought or scheduled, and the way its quantity is applied. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-wallet-payment/">REST API Reference for UpdateWalletPayment Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        Task<BooleanWrapper> UpdateWalletPaymentAsync(WalletQuantityRequestDto? walletQuantityRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Change a wallet service quantity
        /// </summary>
        /// <remarks>
        /// Buys more units of a wallet service - extra administrators, disk storage, backup, AI tools, AI search or  DocsCloud - or writes down the quantity that service will have after the next renewal, depending on  `productQuantityType`. With `Add` (1) the units are bought at once and paid out of the portal wallet, so the  wallet needs a sub-account in the accounting currency and enough money on it; with `Set` (0) nothing is  charged now and the quantity only takes effect in the next period, where an empty or zero quantity cancels a  change scheduled earlier. `Renew` and `Sub` are not accepted here. The portal needs a billing customer and the  caller has to be a DocSpace administrator; a service that is an add-on to the plan also needs the plan itself  to be paid, otherwise the answer is 402. Minimum quantities apply - disk storage starts at 100 units, the  DocsCloud developer pack at 10, and the administrators may not be fewer than the portal already has - and in  the `Add` form they are checked only while the portal does not hold that service yet. Asking for the DocsCloud  plan in the `Set` form while the developer pack is active schedules the reversion to it at the next period,  while the upgrade in the other direction is not done here at all: use  `POST api/2.0/settings/docscloud/switchtodevpack`. The result is `true` when the change was accepted; the call  is mutating, spends money in its `Add` form and is limited to ten requests a minute per user by default. Price  the same purchase without paying for it with `PUT api/2.0/portal/payment/calculatewallet`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The wallet service being bought or scheduled, and the way its quantity is applied. (optional)</param>
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
        /// Prices a wallet-service purchase without making it: it returns what buying the requested number of units would  cost right now, so a client can show the amount before asking for a confirmation. Only `productQuantityType`  `Add` (1) is accepted, the quantity must be greater than zero, and the portal needs a billing customer whose  wallet has a sub-account in the accounting currency. The caller has to be a DocSpace administrator. Nothing is  bought, charged or written down - the call is read-only and may be repeated - and the purchase itself is  `PUT api/2.0/portal/payment/updatewallet`. The answer carries the amount with its currency, the quantity it  was computed for and the identifier of the calculation. It is the price of this moment and is not held: it can  differ by the time the purchase is made.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The wallet service being bought or scheduled, and the way its quantity is applied. (optional)</param>
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
        /// Prices a wallet-service purchase without making it: it returns what buying the requested number of units would  cost right now, so a client can show the amount before asking for a confirmation. Only `productQuantityType`  `Add` (1) is accepted, the quantity must be greater than zero, and the portal needs a billing customer whose  wallet has a sub-account in the accounting currency. The caller has to be a DocSpace administrator. Nothing is  bought, charged or written down - the call is read-only and may be repeated - and the purchase itself is  `PUT api/2.0/portal/payment/updatewallet`. The answer carries the amount with its currency, the quantity it  was computed for and the identifier of the calculation. It is the price of this moment and is not held: it can  differ by the time the purchase is made.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The wallet service being bought or scheduled, and the way its quantity is applied. (optional)</param>
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
        /// Prices a wallet-service purchase without making it: it returns what buying the requested number of units would  cost right now, so a client can show the amount before asking for a confirmation. Only `productQuantityType`  `Add` (1) is accepted, the quantity must be greater than zero, and the portal needs a billing customer whose  wallet has a sub-account in the accounting currency. The caller has to be a DocSpace administrator. Nothing is  bought, charged or written down - the call is read-only and may be repeated - and the purchase itself is  `PUT api/2.0/portal/payment/updatewallet`. The answer carries the amount with its currency, the quantity it  was computed for and the identifier of the calculation. It is the price of this moment and is not held: it can  differ by the time the purchase is made.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The wallet service being bought or scheduled, and the way its quantity is applied. (optional)</param>
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
        /// Prices a wallet-service purchase without making it: it returns what buying the requested number of units would  cost right now, so a client can show the amount before asking for a confirmation. Only `productQuantityType`  `Add` (1) is accepted, the quantity must be greater than zero, and the portal needs a billing customer whose  wallet has a sub-account in the accounting currency. The caller has to be a DocSpace administrator. Nothing is  bought, charged or written down - the call is read-only and may be repeated - and the purchase itself is  `PUT api/2.0/portal/payment/updatewallet`. The answer carries the amount with its currency, the quantity it  was computed for and the identifier of the calculation. It is the price of this moment and is not held: it can  differ by the time the purchase is made.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The wallet service being bought or scheduled, and the way its quantity is applied. (optional)</param>
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
        /// Switch a wallet service
        /// </summary>
        /// <remarks>
        /// Switches one wallet service on or off for the portal: `service` names it and `enabled` says which way. The  portal needs a billing customer, and the caller needs both the permission to edit the portal settings and  DocSpace administrator rights. Order matters between the two AI services - AI tools has to be on before AI  search may be switched on, and switching AI tools off switches AI search off with it - so a request that  breaks that order is refused with 403. The call is mutating and idempotent: switching on a service that is  already on changes nothing. It is written to the portal audit trail, and switching AI tools notifies the  portal clients so the AI features appear or disappear for them without a reload. The whole updated set of  switched-on services comes back. Switching a service on does not buy it - its units are still bought with  `PUT api/2.0/portal/payment/updatewallet`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="changeWalletServiceStateRequestDto">Which wallet service is switched, and which way. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-tenant-wallet-service-state/">REST API Reference for ChangeTenantWalletServiceState Operation</seealso>
        /// <returns>TenantWalletServiceSettingsWrapper</returns>
        public TenantWalletServiceSettingsWrapper ChangeTenantWalletServiceState(ChangeWalletServiceStateRequestDto? changeWalletServiceStateRequestDto = default)
        {
            var localVarResponse = ChangeTenantWalletServiceStateWithHttpInfo(changeWalletServiceStateRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Switch a wallet service
        /// </summary>
        /// <remarks>
        /// Switches one wallet service on or off for the portal: `service` names it and `enabled` says which way. The  portal needs a billing customer, and the caller needs both the permission to edit the portal settings and  DocSpace administrator rights. Order matters between the two AI services - AI tools has to be on before AI  search may be switched on, and switching AI tools off switches AI search off with it - so a request that  breaks that order is refused with 403. The call is mutating and idempotent: switching on a service that is  already on changes nothing. It is written to the portal audit trail, and switching AI tools notifies the  portal clients so the AI features appear or disappear for them without a reload. The whole updated set of  switched-on services comes back. Switching a service on does not buy it - its units are still bought with  `PUT api/2.0/portal/payment/updatewallet`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="changeWalletServiceStateRequestDto">Which wallet service is switched, and which way. (optional)</param>
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
        /// Switch a wallet service
        /// </summary>
        /// <remarks>
        /// Switches one wallet service on or off for the portal: `service` names it and `enabled` says which way. The  portal needs a billing customer, and the caller needs both the permission to edit the portal settings and  DocSpace administrator rights. Order matters between the two AI services - AI tools has to be on before AI  search may be switched on, and switching AI tools off switches AI search off with it - so a request that  breaks that order is refused with 403. The call is mutating and idempotent: switching on a service that is  already on changes nothing. It is written to the portal audit trail, and switching AI tools notifies the  portal clients so the AI features appear or disappear for them without a reload. The whole updated set of  switched-on services comes back. Switching a service on does not buy it - its units are still bought with  `PUT api/2.0/portal/payment/updatewallet`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="changeWalletServiceStateRequestDto">Which wallet service is switched, and which way. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-tenant-wallet-service-state/">REST API Reference for ChangeTenantWalletServiceState Operation</seealso>
        /// <returns>Task of TenantWalletServiceSettingsWrapper</returns>
        public async Task<TenantWalletServiceSettingsWrapper> ChangeTenantWalletServiceStateAsync(ChangeWalletServiceStateRequestDto? changeWalletServiceStateRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await ChangeTenantWalletServiceStateWithHttpInfoAsync(changeWalletServiceStateRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Switch a wallet service
        /// </summary>
        /// <remarks>
        /// Switches one wallet service on or off for the portal: `service` names it and `enabled` says which way. The  portal needs a billing customer, and the caller needs both the permission to edit the portal settings and  DocSpace administrator rights. Order matters between the two AI services - AI tools has to be on before AI  search may be switched on, and switching AI tools off switches AI search off with it - so a request that  breaks that order is refused with 403. The call is mutating and idempotent: switching on a service that is  already on changes nothing. It is written to the portal audit trail, and switching AI tools notifies the  portal clients so the AI features appear or disappear for them without a reload. The whole updated set of  switched-on services comes back. Switching a service on does not buy it - its units are still bought with  `PUT api/2.0/portal/payment/updatewallet`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="changeWalletServiceStateRequestDto">Which wallet service is switched, and which way. (optional)</param>
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
        /// Start the monthly usage report
        /// </summary>
        /// <remarks>
        /// Queues the wallet spending added up per calendar month as an `xlsx` file and returns the task that will build  it; the file is not ready when the response arrives. The portal needs a billing customer and the caller has to  be a DocSpace administrator. The body takes only the period - `startDate` and `endDate`, both inclusive - and  an empty body covers everything from the portal creation date to now; the months are cut in the portal time  zone, exactly as in `GET api/2.0/portal/payment/customer/usage/monthly`. Poll  `GET api/2.0/portal/payment/customer/usage/monthly/report` until `isCompleted` is true, then take the file  from `resultFileUrl` or open `resultFileId`: the finished file is saved into the caller's own My documents  section, where it counts against the portal storage like any other file. One monthly usage report per user is  tracked at a time - a call made while the previous one is still running answers with that task - and  `DELETE api/2.0/portal/payment/customer/usage/monthly/report` stops it. There is no service filter here: for a  report per service use `POST api/2.0/portal/payment/customer/usage/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerMonthlyUsageReportRequestDto">The period covered by the monthly wallet spending report. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-monthly-usage-report/">REST API Reference for CreateCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>DocumentBuilderTaskWrapper</returns>
        public DocumentBuilderTaskWrapper CreateCustomerMonthlyUsageReport(CustomerMonthlyUsageReportRequestDto? customerMonthlyUsageReportRequestDto = default)
        {
            var localVarResponse = CreateCustomerMonthlyUsageReportWithHttpInfo(customerMonthlyUsageReportRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Start the monthly usage report
        /// </summary>
        /// <remarks>
        /// Queues the wallet spending added up per calendar month as an `xlsx` file and returns the task that will build  it; the file is not ready when the response arrives. The portal needs a billing customer and the caller has to  be a DocSpace administrator. The body takes only the period - `startDate` and `endDate`, both inclusive - and  an empty body covers everything from the portal creation date to now; the months are cut in the portal time  zone, exactly as in `GET api/2.0/portal/payment/customer/usage/monthly`. Poll  `GET api/2.0/portal/payment/customer/usage/monthly/report` until `isCompleted` is true, then take the file  from `resultFileUrl` or open `resultFileId`: the finished file is saved into the caller's own My documents  section, where it counts against the portal storage like any other file. One monthly usage report per user is  tracked at a time - a call made while the previous one is still running answers with that task - and  `DELETE api/2.0/portal/payment/customer/usage/monthly/report` stops it. There is no service filter here: for a  report per service use `POST api/2.0/portal/payment/customer/usage/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerMonthlyUsageReportRequestDto">The period covered by the monthly wallet spending report. (optional)</param>
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
        /// Start the monthly usage report
        /// </summary>
        /// <remarks>
        /// Queues the wallet spending added up per calendar month as an `xlsx` file and returns the task that will build  it; the file is not ready when the response arrives. The portal needs a billing customer and the caller has to  be a DocSpace administrator. The body takes only the period - `startDate` and `endDate`, both inclusive - and  an empty body covers everything from the portal creation date to now; the months are cut in the portal time  zone, exactly as in `GET api/2.0/portal/payment/customer/usage/monthly`. Poll  `GET api/2.0/portal/payment/customer/usage/monthly/report` until `isCompleted` is true, then take the file  from `resultFileUrl` or open `resultFileId`: the finished file is saved into the caller's own My documents  section, where it counts against the portal storage like any other file. One monthly usage report per user is  tracked at a time - a call made while the previous one is still running answers with that task - and  `DELETE api/2.0/portal/payment/customer/usage/monthly/report` stops it. There is no service filter here: for a  report per service use `POST api/2.0/portal/payment/customer/usage/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerMonthlyUsageReportRequestDto">The period covered by the monthly wallet spending report. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-monthly-usage-report/">REST API Reference for CreateCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>Task of DocumentBuilderTaskWrapper</returns>
        public async Task<DocumentBuilderTaskWrapper> CreateCustomerMonthlyUsageReportAsync(CustomerMonthlyUsageReportRequestDto? customerMonthlyUsageReportRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateCustomerMonthlyUsageReportWithHttpInfoAsync(customerMonthlyUsageReportRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Start the monthly usage report
        /// </summary>
        /// <remarks>
        /// Queues the wallet spending added up per calendar month as an `xlsx` file and returns the task that will build  it; the file is not ready when the response arrives. The portal needs a billing customer and the caller has to  be a DocSpace administrator. The body takes only the period - `startDate` and `endDate`, both inclusive - and  an empty body covers everything from the portal creation date to now; the months are cut in the portal time  zone, exactly as in `GET api/2.0/portal/payment/customer/usage/monthly`. Poll  `GET api/2.0/portal/payment/customer/usage/monthly/report` until `isCompleted` is true, then take the file  from `resultFileUrl` or open `resultFileId`: the finished file is saved into the caller's own My documents  section, where it counts against the portal storage like any other file. One monthly usage report per user is  tracked at a time - a call made while the previous one is still running answers with that task - and  `DELETE api/2.0/portal/payment/customer/usage/monthly/report` stops it. There is no service filter here: for a  report per service use `POST api/2.0/portal/payment/customer/usage/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerMonthlyUsageReportRequestDto">The period covered by the monthly wallet spending report. (optional)</param>
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
        /// Start the operations report
        /// </summary>
        /// <remarks>
        /// Queues the history of the wallet movements as an `xlsx` file and returns the task that will build it; the file  is not ready when the response arrives. The portal needs a billing customer and the caller has to be a  DocSpace administrator. The body takes the same filters as `GET api/2.0/portal/payment/customer/operations` -  the service names, the date range, the participant, the operation type and status, the credit and debit  directions and the ordering - and an empty body reports everything from the portal creation date to now; a  service name this installation does not sell fails with 404. Poll  `GET api/2.0/portal/payment/customer/operationsreport` until `isCompleted` is true, then take the file from  `resultFileUrl` or open `resultFileId`: the finished file is saved into the caller's own My documents section,  where it counts against the portal storage like any other file. One operations report per user is tracked at a  time - a call made while the previous one is still running answers with that task - and  `DELETE api/2.0/portal/payment/customer/operationsreport` stops it. A build that fails ends the task with  `error` filled in rather than failing this call.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerOperationsReportRequestDto">The filters that select which wallet movements are reported: the services, the period, the participant, the  direction and the outcome of the movement, and the ordering. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-operations-report/">REST API Reference for CreateCustomerOperationsReport Operation</seealso>
        /// <returns>DocumentBuilderTaskWrapper</returns>
        public DocumentBuilderTaskWrapper CreateCustomerOperationsReport(CustomerOperationsReportRequestDto? customerOperationsReportRequestDto = default)
        {
            var localVarResponse = CreateCustomerOperationsReportWithHttpInfo(customerOperationsReportRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Start the operations report
        /// </summary>
        /// <remarks>
        /// Queues the history of the wallet movements as an `xlsx` file and returns the task that will build it; the file  is not ready when the response arrives. The portal needs a billing customer and the caller has to be a  DocSpace administrator. The body takes the same filters as `GET api/2.0/portal/payment/customer/operations` -  the service names, the date range, the participant, the operation type and status, the credit and debit  directions and the ordering - and an empty body reports everything from the portal creation date to now; a  service name this installation does not sell fails with 404. Poll  `GET api/2.0/portal/payment/customer/operationsreport` until `isCompleted` is true, then take the file from  `resultFileUrl` or open `resultFileId`: the finished file is saved into the caller's own My documents section,  where it counts against the portal storage like any other file. One operations report per user is tracked at a  time - a call made while the previous one is still running answers with that task - and  `DELETE api/2.0/portal/payment/customer/operationsreport` stops it. A build that fails ends the task with  `error` filled in rather than failing this call.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerOperationsReportRequestDto">The filters that select which wallet movements are reported: the services, the period, the participant, the  direction and the outcome of the movement, and the ordering. (optional)</param>
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
        /// Start the operations report
        /// </summary>
        /// <remarks>
        /// Queues the history of the wallet movements as an `xlsx` file and returns the task that will build it; the file  is not ready when the response arrives. The portal needs a billing customer and the caller has to be a  DocSpace administrator. The body takes the same filters as `GET api/2.0/portal/payment/customer/operations` -  the service names, the date range, the participant, the operation type and status, the credit and debit  directions and the ordering - and an empty body reports everything from the portal creation date to now; a  service name this installation does not sell fails with 404. Poll  `GET api/2.0/portal/payment/customer/operationsreport` until `isCompleted` is true, then take the file from  `resultFileUrl` or open `resultFileId`: the finished file is saved into the caller's own My documents section,  where it counts against the portal storage like any other file. One operations report per user is tracked at a  time - a call made while the previous one is still running answers with that task - and  `DELETE api/2.0/portal/payment/customer/operationsreport` stops it. A build that fails ends the task with  `error` filled in rather than failing this call.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerOperationsReportRequestDto">The filters that select which wallet movements are reported: the services, the period, the participant, the  direction and the outcome of the movement, and the ordering. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-operations-report/">REST API Reference for CreateCustomerOperationsReport Operation</seealso>
        /// <returns>Task of DocumentBuilderTaskWrapper</returns>
        public async Task<DocumentBuilderTaskWrapper> CreateCustomerOperationsReportAsync(CustomerOperationsReportRequestDto? customerOperationsReportRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateCustomerOperationsReportWithHttpInfoAsync(customerOperationsReportRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Start the operations report
        /// </summary>
        /// <remarks>
        /// Queues the history of the wallet movements as an `xlsx` file and returns the task that will build it; the file  is not ready when the response arrives. The portal needs a billing customer and the caller has to be a  DocSpace administrator. The body takes the same filters as `GET api/2.0/portal/payment/customer/operations` -  the service names, the date range, the participant, the operation type and status, the credit and debit  directions and the ordering - and an empty body reports everything from the portal creation date to now; a  service name this installation does not sell fails with 404. Poll  `GET api/2.0/portal/payment/customer/operationsreport` until `isCompleted` is true, then take the file from  `resultFileUrl` or open `resultFileId`: the finished file is saved into the caller's own My documents section,  where it counts against the portal storage like any other file. One operations report per user is tracked at a  time - a call made while the previous one is still running answers with that task - and  `DELETE api/2.0/portal/payment/customer/operationsreport` stops it. A build that fails ends the task with  `error` filled in rather than failing this call.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerOperationsReportRequestDto">The filters that select which wallet movements are reported: the services, the period, the participant, the  direction and the outcome of the movement, and the ordering. (optional)</param>
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
        /// Start the service usage report
        /// </summary>
        /// <remarks>
        /// Queues the usage of the wallet services as an `xlsx` file and returns the task that will build it; the file is  not ready when the response arrives. The portal needs a billing customer and the caller has to be a DocSpace  administrator. The body takes the same filters as `GET api/2.0/portal/payment/customer/usage` - the service  names, the date range, the participant, the operation status, the usage metadata and the ordering - and an  empty body reports every service from the portal creation date to now; a service name this installation does  not sell fails with 404. Poll `GET api/2.0/portal/payment/customer/usage/report` until `isCompleted` is true,  then take the file from `resultFileUrl` or open `resultFileId`: the finished file is saved into the caller's  own My documents section, where it counts against the portal storage like any other file. One service usage  report per user is tracked at a time - a call made while the previous one is still running answers with that  task - and `DELETE api/2.0/portal/payment/customer/usage/report` stops it. It is a different report from the  operations one and does not interfere with it: per-movement history is  `POST api/2.0/portal/payment/customer/operationsreport`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerServiceUsageReportRequestDto">The filters that select which wallet service consumption is reported: the services, the period, the participant,  the outcome, the usage metadata and the ordering. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-service-usage-report/">REST API Reference for CreateCustomerServiceUsageReport Operation</seealso>
        /// <returns>DocumentBuilderTaskWrapper</returns>
        public DocumentBuilderTaskWrapper CreateCustomerServiceUsageReport(CustomerServiceUsageReportRequestDto? customerServiceUsageReportRequestDto = default)
        {
            var localVarResponse = CreateCustomerServiceUsageReportWithHttpInfo(customerServiceUsageReportRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Start the service usage report
        /// </summary>
        /// <remarks>
        /// Queues the usage of the wallet services as an `xlsx` file and returns the task that will build it; the file is  not ready when the response arrives. The portal needs a billing customer and the caller has to be a DocSpace  administrator. The body takes the same filters as `GET api/2.0/portal/payment/customer/usage` - the service  names, the date range, the participant, the operation status, the usage metadata and the ordering - and an  empty body reports every service from the portal creation date to now; a service name this installation does  not sell fails with 404. Poll `GET api/2.0/portal/payment/customer/usage/report` until `isCompleted` is true,  then take the file from `resultFileUrl` or open `resultFileId`: the finished file is saved into the caller's  own My documents section, where it counts against the portal storage like any other file. One service usage  report per user is tracked at a time - a call made while the previous one is still running answers with that  task - and `DELETE api/2.0/portal/payment/customer/usage/report` stops it. It is a different report from the  operations one and does not interfere with it: per-movement history is  `POST api/2.0/portal/payment/customer/operationsreport`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerServiceUsageReportRequestDto">The filters that select which wallet service consumption is reported: the services, the period, the participant,  the outcome, the usage metadata and the ordering. (optional)</param>
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
        /// Start the service usage report
        /// </summary>
        /// <remarks>
        /// Queues the usage of the wallet services as an `xlsx` file and returns the task that will build it; the file is  not ready when the response arrives. The portal needs a billing customer and the caller has to be a DocSpace  administrator. The body takes the same filters as `GET api/2.0/portal/payment/customer/usage` - the service  names, the date range, the participant, the operation status, the usage metadata and the ordering - and an  empty body reports every service from the portal creation date to now; a service name this installation does  not sell fails with 404. Poll `GET api/2.0/portal/payment/customer/usage/report` until `isCompleted` is true,  then take the file from `resultFileUrl` or open `resultFileId`: the finished file is saved into the caller's  own My documents section, where it counts against the portal storage like any other file. One service usage  report per user is tracked at a time - a call made while the previous one is still running answers with that  task - and `DELETE api/2.0/portal/payment/customer/usage/report` stops it. It is a different report from the  operations one and does not interfere with it: per-movement history is  `POST api/2.0/portal/payment/customer/operationsreport`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerServiceUsageReportRequestDto">The filters that select which wallet service consumption is reported: the services, the period, the participant,  the outcome, the usage metadata and the ordering. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-customer-service-usage-report/">REST API Reference for CreateCustomerServiceUsageReport Operation</seealso>
        /// <returns>Task of DocumentBuilderTaskWrapper</returns>
        public async Task<DocumentBuilderTaskWrapper> CreateCustomerServiceUsageReportAsync(CustomerServiceUsageReportRequestDto? customerServiceUsageReportRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateCustomerServiceUsageReportWithHttpInfoAsync(customerServiceUsageReportRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Start the service usage report
        /// </summary>
        /// <remarks>
        /// Queues the usage of the wallet services as an `xlsx` file and returns the task that will build it; the file is  not ready when the response arrives. The portal needs a billing customer and the caller has to be a DocSpace  administrator. The body takes the same filters as `GET api/2.0/portal/payment/customer/usage` - the service  names, the date range, the participant, the operation status, the usage metadata and the ordering - and an  empty body reports every service from the portal creation date to now; a service name this installation does  not sell fails with 404. Poll `GET api/2.0/portal/payment/customer/usage/report` until `isCompleted` is true,  then take the file from `resultFileUrl` or open `resultFileId`: the finished file is saved into the caller's  own My documents section, where it counts against the portal storage like any other file. One service usage  report per user is tracked at a time - a call made while the previous one is still running answers with that  task - and `DELETE api/2.0/portal/payment/customer/usage/report` stops it. It is a different report from the  operations one and does not interfere with it: per-movement history is  `POST api/2.0/portal/payment/customer/operationsreport`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerServiceUsageReportRequestDto">The filters that select which wallet service consumption is reported: the services, the period, the participant,  the outcome, the usage metadata and the ordering. (optional)</param>
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
        /// Get the service prices from the accounting service
        /// </summary>
        /// <remarks>
        /// Returns the portal's automatic wallet top-up settings: whether it is switched on, the balance that triggers  it, the balance it tops the wallet up to and the currency it charges in. Only a DocSpace administrator may  read it, no billing customer is needed, and the call is read-only. A portal that has never configured it gets  the defaults rather than an empty result, so `enabled` is the field that says whether anything happens at all.  Two of the values are kept by the portal itself and cannot be set through this API: `lowBalanceThreshold` is  the balance below which the portal warns its administrators by mail, and `lowBalanceNotified` says whether  that warning has already gone out for the current dip. Change the rest with  `POST api/2.0/portal/payment/topupsettings`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName">The service whose price list is read, named the way the billing catalogue names it, such as `ai-tools` or  `backup`. Take the value from the `serviceName` field of `GET api/2.0/portal/payment/walletservices`; a name  the accounting service does not price yields an empty list rather than an error.</param>
        /// <param name="active">Whether the answer is narrowed to the prices in force at the moment of the call. Leaving it false also  returns the retired and the not yet started ones, which is what pricing a movement recorded in the past  needs. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounting-service-prices/">REST API Reference for GetAccountingServicePrices Operation</seealso>
        /// <returns>ServicePriceInfoArrayWrapper</returns>
        public ServicePriceInfoArrayWrapper GetAccountingServicePrices(string serviceName, bool? active = default)
        {
            var localVarResponse = GetAccountingServicePricesWithHttpInfo(serviceName, active);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the service prices from the accounting service
        /// </summary>
        /// <remarks>
        /// Returns the portal's automatic wallet top-up settings: whether it is switched on, the balance that triggers  it, the balance it tops the wallet up to and the currency it charges in. Only a DocSpace administrator may  read it, no billing customer is needed, and the call is read-only. A portal that has never configured it gets  the defaults rather than an empty result, so `enabled` is the field that says whether anything happens at all.  Two of the values are kept by the portal itself and cannot be set through this API: `lowBalanceThreshold` is  the balance below which the portal warns its administrators by mail, and `lowBalanceNotified` says whether  that warning has already gone out for the current dip. Change the rest with  `POST api/2.0/portal/payment/topupsettings`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName">The service whose price list is read, named the way the billing catalogue names it, such as `ai-tools` or  `backup`. Take the value from the `serviceName` field of `GET api/2.0/portal/payment/walletservices`; a name  the accounting service does not price yields an empty list rather than an error.</param>
        /// <param name="active">Whether the answer is narrowed to the prices in force at the moment of the call. Leaving it false also  returns the retired and the not yet started ones, which is what pricing a movement recorded in the past  needs. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounting-service-prices/">REST API Reference for GetAccountingServicePrices Operation</seealso>
        /// <returns>ApiResponse of ServicePriceInfoArrayWrapper</returns>
        public ApiResponse<ServicePriceInfoArrayWrapper> GetAccountingServicePricesWithHttpInfo(string serviceName, bool? active = default)
        {
            // verify the required parameter 'serviceName' is set
            if (serviceName == null)
                throw new ApiException(400, "Missing required parameter 'serviceName' when calling PaymentApi->GetAccountingServicePrices");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("serviceName", ClientUtils.ParameterToString(serviceName)); // path parameter
            if (active != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "active", active));
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
            var localVarResponse = Client.Get<ServicePriceInfoArrayWrapper>("/api/2.0/portal/payment/accounting/prices/{serviceName}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAccountingServicePrices", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the service prices from the accounting service
        /// </summary>
        /// <remarks>
        /// Returns the portal's automatic wallet top-up settings: whether it is switched on, the balance that triggers  it, the balance it tops the wallet up to and the currency it charges in. Only a DocSpace administrator may  read it, no billing customer is needed, and the call is read-only. A portal that has never configured it gets  the defaults rather than an empty result, so `enabled` is the field that says whether anything happens at all.  Two of the values are kept by the portal itself and cannot be set through this API: `lowBalanceThreshold` is  the balance below which the portal warns its administrators by mail, and `lowBalanceNotified` says whether  that warning has already gone out for the current dip. Change the rest with  `POST api/2.0/portal/payment/topupsettings`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName">The service whose price list is read, named the way the billing catalogue names it, such as `ai-tools` or  `backup`. Take the value from the `serviceName` field of `GET api/2.0/portal/payment/walletservices`; a name  the accounting service does not price yields an empty list rather than an error.</param>
        /// <param name="active">Whether the answer is narrowed to the prices in force at the moment of the call. Leaving it false also  returns the retired and the not yet started ones, which is what pricing a movement recorded in the past  needs. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounting-service-prices/">REST API Reference for GetAccountingServicePrices Operation</seealso>
        /// <returns>Task of ServicePriceInfoArrayWrapper</returns>
        public async Task<ServicePriceInfoArrayWrapper> GetAccountingServicePricesAsync(string serviceName, bool? active = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetAccountingServicePricesWithHttpInfoAsync(serviceName, active, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the service prices from the accounting service
        /// </summary>
        /// <remarks>
        /// Returns the portal's automatic wallet top-up settings: whether it is switched on, the balance that triggers  it, the balance it tops the wallet up to and the currency it charges in. Only a DocSpace administrator may  read it, no billing customer is needed, and the call is read-only. A portal that has never configured it gets  the defaults rather than an empty result, so `enabled` is the field that says whether anything happens at all.  Two of the values are kept by the portal itself and cannot be set through this API: `lowBalanceThreshold` is  the balance below which the portal warns its administrators by mail, and `lowBalanceNotified` says whether  that warning has already gone out for the current dip. Change the rest with  `POST api/2.0/portal/payment/topupsettings`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName">The service whose price list is read, named the way the billing catalogue names it, such as `ai-tools` or  `backup`. Take the value from the `serviceName` field of `GET api/2.0/portal/payment/walletservices`; a name  the accounting service does not price yields an empty list rather than an error.</param>
        /// <param name="active">Whether the answer is narrowed to the prices in force at the moment of the call. Leaving it false also  returns the retired and the not yet started ones, which is what pricing a movement recorded in the past  needs. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounting-service-prices/">REST API Reference for GetAccountingServicePrices Operation</seealso>
        /// <returns>Task of ApiResponse (ServicePriceInfoArrayWrapper)</returns>
        public async Task<ApiResponse<ServicePriceInfoArrayWrapper>> GetAccountingServicePricesWithHttpInfoAsync(string serviceName, bool? active = default, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'serviceName' is set
            if (serviceName == null)
                throw new ApiException(400, "Missing required parameter 'serviceName' when calling PaymentApi->GetAccountingServicePrices");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("serviceName", ClientUtils.ParameterToString(serviceName)); // path parameter
            if (active != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "active", active));
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

            var localVarResponse = await AsynchronousClient.GetAsync<ServicePriceInfoArrayWrapper>("/api/2.0/portal/payment/accounting/prices/{serviceName}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAccountingServicePrices", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the active wallet services
        /// </summary>
        /// <remarks>
        /// Lists the wallet services the portal is running right now: the add-ons its plan pays for that are in the  active state, plus the ones an administrator switched on by hand in the wallet service settings; the DocsCloud  trial is listed as well, although it is not paid from the wallet. Only a DocSpace administrator may call it,  no billing customer is needed for it, and the call is read-only. Every item names the service, its title and  the unit it is measured in, and says whether it is a subscription; a subscribed service also carries the limit  it grants and how much of it is used where that number is known - the editor seats and the editors currently  active for DocsCloud, the purchased units and the units already consumed for disk storage. A service listed  with no limit is one whose usage is not counted this way, not one without a limit. The catalogue of what could  be switched on is `GET api/2.0/portal/payment/walletservices`, and switching one is  `POST api/2.0/portal/payment/servicestate`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-active-services/">REST API Reference for GetActiveServices Operation</seealso>
        /// <returns>ActiveServiceArrayWrapper</returns>
        public ActiveServiceArrayWrapper GetActiveServices()
        {
            var localVarResponse = GetActiveServicesWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the active wallet services
        /// </summary>
        /// <remarks>
        /// Lists the wallet services the portal is running right now: the add-ons its plan pays for that are in the  active state, plus the ones an administrator switched on by hand in the wallet service settings; the DocsCloud  trial is listed as well, although it is not paid from the wallet. Only a DocSpace administrator may call it,  no billing customer is needed for it, and the call is read-only. Every item names the service, its title and  the unit it is measured in, and says whether it is a subscription; a subscribed service also carries the limit  it grants and how much of it is used where that number is known - the editor seats and the editors currently  active for DocsCloud, the purchased units and the units already consumed for disk storage. A service listed  with no limit is one whose usage is not counted this way, not one without a limit. The catalogue of what could  be switched on is `GET api/2.0/portal/payment/walletservices`, and switching one is  `POST api/2.0/portal/payment/servicestate`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-active-services/">REST API Reference for GetActiveServices Operation</seealso>
        /// <returns>ApiResponse of ActiveServiceArrayWrapper</returns>
        public ApiResponse<ActiveServiceArrayWrapper> GetActiveServicesWithHttpInfo()
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
            var localVarResponse = Client.Get<ActiveServiceArrayWrapper>("/api/2.0/portal/payment/activeservices", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetActiveServices", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the active wallet services
        /// </summary>
        /// <remarks>
        /// Lists the wallet services the portal is running right now: the add-ons its plan pays for that are in the  active state, plus the ones an administrator switched on by hand in the wallet service settings; the DocsCloud  trial is listed as well, although it is not paid from the wallet. Only a DocSpace administrator may call it,  no billing customer is needed for it, and the call is read-only. Every item names the service, its title and  the unit it is measured in, and says whether it is a subscription; a subscribed service also carries the limit  it grants and how much of it is used where that number is known - the editor seats and the editors currently  active for DocsCloud, the purchased units and the units already consumed for disk storage. A service listed  with no limit is one whose usage is not counted this way, not one without a limit. The catalogue of what could  be switched on is `GET api/2.0/portal/payment/walletservices`, and switching one is  `POST api/2.0/portal/payment/servicestate`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-active-services/">REST API Reference for GetActiveServices Operation</seealso>
        /// <returns>Task of ActiveServiceArrayWrapper</returns>
        public async Task<ActiveServiceArrayWrapper> GetActiveServicesAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetActiveServicesWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the active wallet services
        /// </summary>
        /// <remarks>
        /// Lists the wallet services the portal is running right now: the add-ons its plan pays for that are in the  active state, plus the ones an administrator switched on by hand in the wallet service settings; the DocsCloud  trial is listed as well, although it is not paid from the wallet. Only a DocSpace administrator may call it,  no billing customer is needed for it, and the call is read-only. Every item names the service, its title and  the unit it is measured in, and says whether it is a subscription; a subscribed service also carries the limit  it grants and how much of it is used where that number is known - the editor seats and the editors currently  active for DocsCloud, the purchased units and the units already consumed for disk storage. A service listed  with no limit is one whose usage is not counted this way, not one without a limit. The catalogue of what could  be switched on is `GET api/2.0/portal/payment/walletservices`, and switching one is  `POST api/2.0/portal/payment/servicestate`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-active-services/">REST API Reference for GetActiveServices Operation</seealso>
        /// <returns>Task of ApiResponse (ActiveServiceArrayWrapper)</returns>
        public async Task<ApiResponse<ActiveServiceArrayWrapper>> GetActiveServicesWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<ActiveServiceArrayWrapper>("/api/2.0/portal/payment/activeservices", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetActiveServices", localVarResponse);
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
        /// Returns the price list of the AI features the portal pays for out of its wallet: the chat models with the  price of their prompt and completion tokens, the embedding models, the image models with their per-image  price, and the web search providers with the price of one search. The installation needs both a billing  service and the AI gateway configured, otherwise the answer is 403, and only a DocSpace administrator may read  it; the call is read-only. Token prices are normalised per million tokens, and every price is in the single  `currency` the answer names. Each entry carries the model identifier to use when talking to the AI operations,  its display alias, its provider with the provider icon, and a link to the model's own page. It is a list of  what the models cost and not of what the portal spent - that is `GET api/2.0/portal/payment/customer/usage` -  and it says nothing about which of them are allowed here, which is  `GET api/2.0/portal/payment/ai-model/restrictions`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-ai-prices/">REST API Reference for GetAiPrices Operation</seealso>
        /// <returns>AiPricesWrapper</returns>
        public AiPricesWrapper GetAiPrices()
        {
            var localVarResponse = GetAiPricesWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get AI model prices
        /// </summary>
        /// <remarks>
        /// Returns the price list of the AI features the portal pays for out of its wallet: the chat models with the  price of their prompt and completion tokens, the embedding models, the image models with their per-image  price, and the web search providers with the price of one search. The installation needs both a billing  service and the AI gateway configured, otherwise the answer is 403, and only a DocSpace administrator may read  it; the call is read-only. Token prices are normalised per million tokens, and every price is in the single  `currency` the answer names. Each entry carries the model identifier to use when talking to the AI operations,  its display alias, its provider with the provider icon, and a link to the model's own page. It is a list of  what the models cost and not of what the portal spent - that is `GET api/2.0/portal/payment/customer/usage` -  and it says nothing about which of them are allowed here, which is  `GET api/2.0/portal/payment/ai-model/restrictions`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-ai-prices/">REST API Reference for GetAiPrices Operation</seealso>
        /// <returns>ApiResponse of AiPricesWrapper</returns>
        public ApiResponse<AiPricesWrapper> GetAiPricesWithHttpInfo()
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
            var localVarResponse = Client.Get<AiPricesWrapper>("/api/2.0/portal/payment/ai-prices", localVarRequestOptions, Configuration);

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
        /// Returns the price list of the AI features the portal pays for out of its wallet: the chat models with the  price of their prompt and completion tokens, the embedding models, the image models with their per-image  price, and the web search providers with the price of one search. The installation needs both a billing  service and the AI gateway configured, otherwise the answer is 403, and only a DocSpace administrator may read  it; the call is read-only. Token prices are normalised per million tokens, and every price is in the single  `currency` the answer names. Each entry carries the model identifier to use when talking to the AI operations,  its display alias, its provider with the provider icon, and a link to the model's own page. It is a list of  what the models cost and not of what the portal spent - that is `GET api/2.0/portal/payment/customer/usage` -  and it says nothing about which of them are allowed here, which is  `GET api/2.0/portal/payment/ai-model/restrictions`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-ai-prices/">REST API Reference for GetAiPrices Operation</seealso>
        /// <returns>Task of AiPricesWrapper</returns>
        public async Task<AiPricesWrapper> GetAiPricesAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetAiPricesWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get AI model prices
        /// </summary>
        /// <remarks>
        /// Returns the price list of the AI features the portal pays for out of its wallet: the chat models with the  price of their prompt and completion tokens, the embedding models, the image models with their per-image  price, and the web search providers with the price of one search. The installation needs both a billing  service and the AI gateway configured, otherwise the answer is 403, and only a DocSpace administrator may read  it; the call is read-only. Token prices are normalised per million tokens, and every price is in the single  `currency` the answer names. Each entry carries the model identifier to use when talking to the AI operations,  its display alias, its provider with the provider icon, and a link to the model's own page. It is a list of  what the models cost and not of what the portal spent - that is `GET api/2.0/portal/payment/customer/usage` -  and it says nothing about which of them are allowed here, which is  `GET api/2.0/portal/payment/ai-model/restrictions`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-ai-prices/">REST API Reference for GetAiPrices Operation</seealso>
        /// <returns>Task of ApiResponse (AiPricesWrapper)</returns>
        public async Task<ApiResponse<AiPricesWrapper>> GetAiPricesWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<AiPricesWrapper>("/api/2.0/portal/payment/ai-prices", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

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
        /// Hands back the hosted page on which a payment method is attached to the portal's billing account, for the case  where money has to be taken later - a wallet top-up or an automatic one - rather than a plan bought now. A  portal that already has a payment method on file answers with an empty result; a DocSpace administrator may  ask for the page, but once the portal has a billing customer with an e-mail, only its payer may. The call  itself changes nothing and may be repeated: the payment method is stored by the payment provider when the  returned page is completed, after which `GET api/2.0/portal/payment/customerinfo` reports it as set. The URL  is absolute, carries the caller's e-mail, the language of the request and the currency of the region, and  redirects to `successUrl` or `backUrl` when the user finishes or cancels. It buys nothing - a plan is bought  with `PUT api/2.0/portal/payment/url`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">The absolute address the setup page sends the user back to when attaching a payment method is abandoned. It  has to be a well-formed URL and must be reachable by that user rather than by the portal.</param>
        /// <param name="successUrl">The absolute address the setup page sends the user to once the payment provider has stored the payment  method. Reaching it means a method is now on file, which `GET api/2.0/portal/payment/customerinfo` confirms;  nothing has been charged.</param>
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
        /// Hands back the hosted page on which a payment method is attached to the portal's billing account, for the case  where money has to be taken later - a wallet top-up or an automatic one - rather than a plan bought now. A  portal that already has a payment method on file answers with an empty result; a DocSpace administrator may  ask for the page, but once the portal has a billing customer with an e-mail, only its payer may. The call  itself changes nothing and may be repeated: the payment method is stored by the payment provider when the  returned page is completed, after which `GET api/2.0/portal/payment/customerinfo` reports it as set. The URL  is absolute, carries the caller's e-mail, the language of the request and the currency of the region, and  redirects to `successUrl` or `backUrl` when the user finishes or cancels. It buys nothing - a plan is bought  with `PUT api/2.0/portal/payment/url`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">The absolute address the setup page sends the user back to when attaching a payment method is abandoned. It  has to be a well-formed URL and must be reachable by that user rather than by the portal.</param>
        /// <param name="successUrl">The absolute address the setup page sends the user to once the payment provider has stored the payment  method. Reaching it means a method is now on file, which `GET api/2.0/portal/payment/customerinfo` confirms;  nothing has been charged.</param>
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
        /// Hands back the hosted page on which a payment method is attached to the portal's billing account, for the case  where money has to be taken later - a wallet top-up or an automatic one - rather than a plan bought now. A  portal that already has a payment method on file answers with an empty result; a DocSpace administrator may  ask for the page, but once the portal has a billing customer with an e-mail, only its payer may. The call  itself changes nothing and may be repeated: the payment method is stored by the payment provider when the  returned page is completed, after which `GET api/2.0/portal/payment/customerinfo` reports it as set. The URL  is absolute, carries the caller's e-mail, the language of the request and the currency of the region, and  redirects to `successUrl` or `backUrl` when the user finishes or cancels. It buys nothing - a plan is bought  with `PUT api/2.0/portal/payment/url`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">The absolute address the setup page sends the user back to when attaching a payment method is abandoned. It  has to be a well-formed URL and must be reachable by that user rather than by the portal.</param>
        /// <param name="successUrl">The absolute address the setup page sends the user to once the payment provider has stored the payment  method. Reaching it means a method is now on file, which `GET api/2.0/portal/payment/customerinfo` confirms;  nothing has been charged.</param>
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
        /// Hands back the hosted page on which a payment method is attached to the portal's billing account, for the case  where money has to be taken later - a wallet top-up or an automatic one - rather than a plan bought now. A  portal that already has a payment method on file answers with an empty result; a DocSpace administrator may  ask for the page, but once the portal has a billing customer with an e-mail, only its payer may. The call  itself changes nothing and may be repeated: the payment method is stored by the payment provider when the  returned page is completed, after which `GET api/2.0/portal/payment/customerinfo` reports it as set. The URL  is absolute, carries the caller's e-mail, the language of the request and the currency of the region, and  redirects to `successUrl` or `backUrl` when the user finishes or cancels. It buys nothing - a plan is bought  with `PUT api/2.0/portal/payment/url`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">The absolute address the setup page sends the user back to when attaching a payment method is abandoned. It  has to be a well-formed URL and must be reachable by that user rather than by the portal.</param>
        /// <param name="successUrl">The absolute address the setup page sends the user to once the payment provider has stored the payment  method. Reaching it means a method is now on file, which `GET api/2.0/portal/payment/customerinfo` confirms;  nothing has been charged.</param>
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
        /// Get the customer balance
        /// </summary>
        /// <remarks>
        /// Returns the money the portal has in its wallet as the accounting service holds it: the account with its own  currency, one sub-account per currency with the amount on it, and the most recent credit movement. Only a  DocSpace administrator may read it, an installation without a billing service answers 403, and a portal that  has never been a customer gets an empty result. The call is read-only. This balance is what the wallet  services are charged against, so it falls as they are used and rises with  `POST api/2.0/portal/payment/deposit`; the movements behind a change are listed by  `GET api/2.0/portal/payment/customer/operations`. Pass `refresh=true` to re-read it from the accounting  service rather than the cache - right after a top-up the cached figure is still the old one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Whether the answer is fetched from the billing service instead of the portal cache. The cached copy is what a  start-up needs and costs nothing; asking for a fresh one makes a remote call, so use it right after a  purchase or a top-up and not on every read. (optional)</param>
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
        /// Returns the money the portal has in its wallet as the accounting service holds it: the account with its own  currency, one sub-account per currency with the amount on it, and the most recent credit movement. Only a  DocSpace administrator may read it, an installation without a billing service answers 403, and a portal that  has never been a customer gets an empty result. The call is read-only. This balance is what the wallet  services are charged against, so it falls as they are used and rises with  `POST api/2.0/portal/payment/deposit`; the movements behind a change are listed by  `GET api/2.0/portal/payment/customer/operations`. Pass `refresh=true` to re-read it from the accounting  service rather than the cache - right after a top-up the cached figure is still the old one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Whether the answer is fetched from the billing service instead of the portal cache. The cached copy is what a  start-up needs and costs nothing; asking for a fresh one makes a remote call, so use it right after a  purchase or a top-up and not on every read. (optional)</param>
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
        /// Returns the money the portal has in its wallet as the accounting service holds it: the account with its own  currency, one sub-account per currency with the amount on it, and the most recent credit movement. Only a  DocSpace administrator may read it, an installation without a billing service answers 403, and a portal that  has never been a customer gets an empty result. The call is read-only. This balance is what the wallet  services are charged against, so it falls as they are used and rises with  `POST api/2.0/portal/payment/deposit`; the movements behind a change are listed by  `GET api/2.0/portal/payment/customer/operations`. Pass `refresh=true` to re-read it from the accounting  service rather than the cache - right after a top-up the cached figure is still the old one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Whether the answer is fetched from the billing service instead of the portal cache. The cached copy is what a  start-up needs and costs nothing; asking for a fresh one makes a remote call, so use it right after a  purchase or a top-up and not on every read. (optional)</param>
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
        /// Returns the money the portal has in its wallet as the accounting service holds it: the account with its own  currency, one sub-account per currency with the amount on it, and the most recent credit movement. Only a  DocSpace administrator may read it, an installation without a billing service answers 403, and a portal that  has never been a customer gets an empty result. The call is read-only. This balance is what the wallet  services are charged against, so it falls as they are used and rises with  `POST api/2.0/portal/payment/deposit`; the movements behind a change are listed by  `GET api/2.0/portal/payment/customer/operations`. Pass `refresh=true` to re-read it from the accounting  service rather than the cache - right after a top-up the cached figure is still the old one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Whether the answer is fetched from the billing service instead of the portal cache. The cached copy is what a  start-up needs and costs nothing; asking for a fresh one makes a remote call, so use it right after a  purchase or a top-up and not on every read. (optional)</param>
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
        /// Returns the billing customer behind the portal: the e-mail its billing account is registered to, whether a  payment method is stored for it, and the portal user who is the payer of that account. Only a DocSpace  administrator may read it, and the call is read-only. The answer is empty in two ordinary cases - the  installation has no billing service configured at all, and the portal has never been a customer - so an empty  body is not an error. `payer` is filled in only when the billing e-mail belongs to a portal user; when it does  not, the e-mail is still shown but the field stays empty, and that is what makes every payer-only operation of  this group unreachable for everybody. `refresh=true` re-reads the customer from the billing provider instead  of the cache, which is worth doing right after a payment method has been attached.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Whether the answer is fetched from the billing service instead of the portal cache. The cached copy is what a  start-up needs and costs nothing; asking for a fresh one makes a remote call, so use it right after a  purchase or a top-up and not on every read. (optional)</param>
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
        /// Returns the billing customer behind the portal: the e-mail its billing account is registered to, whether a  payment method is stored for it, and the portal user who is the payer of that account. Only a DocSpace  administrator may read it, and the call is read-only. The answer is empty in two ordinary cases - the  installation has no billing service configured at all, and the portal has never been a customer - so an empty  body is not an error. `payer` is filled in only when the billing e-mail belongs to a portal user; when it does  not, the e-mail is still shown but the field stays empty, and that is what makes every payer-only operation of  this group unreachable for everybody. `refresh=true` re-reads the customer from the billing provider instead  of the cache, which is worth doing right after a payment method has been attached.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Whether the answer is fetched from the billing service instead of the portal cache. The cached copy is what a  start-up needs and costs nothing; asking for a fresh one makes a remote call, so use it right after a  purchase or a top-up and not on every read. (optional)</param>
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
        /// Returns the billing customer behind the portal: the e-mail its billing account is registered to, whether a  payment method is stored for it, and the portal user who is the payer of that account. Only a DocSpace  administrator may read it, and the call is read-only. The answer is empty in two ordinary cases - the  installation has no billing service configured at all, and the portal has never been a customer - so an empty  body is not an error. `payer` is filled in only when the billing e-mail belongs to a portal user; when it does  not, the e-mail is still shown but the field stays empty, and that is what makes every payer-only operation of  this group unreachable for everybody. `refresh=true` re-reads the customer from the billing provider instead  of the cache, which is worth doing right after a payment method has been attached.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Whether the answer is fetched from the billing service instead of the portal cache. The cached copy is what a  start-up needs and costs nothing; asking for a fresh one makes a remote call, so use it right after a  purchase or a top-up and not on every read. (optional)</param>
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
        /// Returns the billing customer behind the portal: the e-mail its billing account is registered to, whether a  payment method is stored for it, and the portal user who is the payer of that account. Only a DocSpace  administrator may read it, and the call is read-only. The answer is empty in two ordinary cases - the  installation has no billing service configured at all, and the portal has never been a customer - so an empty  body is not an error. `payer` is filled in only when the billing e-mail belongs to a portal user; when it does  not, the e-mail is still shown but the field stays empty, and that is what makes every payer-only operation of  this group unreachable for everybody. `refresh=true` re-reads the customer from the billing provider instead  of the cache, which is worth doing right after a payment method has been attached.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Whether the answer is fetched from the billing service instead of the portal cache. The cached copy is what a  start-up needs and costs nothing; asking for a fresh one makes a remote call, so use it right after a  purchase or a top-up and not on every read. (optional)</param>
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
        /// Returns what the portal spent from its wallet added up per calendar month, so a client can draw a spending  chart without paging through every movement. Only a DocSpace administrator may read it, a portal with no  billing customer answers with an empty result, and the call is read-only. `startDate` and `endDate` bound the  period, both inclusive, and default to the portal creation date and the present moment; the months are cut in  the portal time zone, so a movement at the edge of a month falls where the portal sees it and not where UTC  does. Each item names its year and month, the total charged in it with the currency, and how many operations  that total came from. The movements behind a month are in `GET api/2.0/portal/payment/customer/operations`,  and the same figures as a file come from `POST api/2.0/portal/payment/customer/usage/monthly/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The beginning of the reported period, inclusive. The months are cut in the portal time zone rather than in  UTC, so spending at the turn of a month falls where the portal sees it; defaults to the portal creation date. (optional)</param>
        /// <param name="endDate">The end of the reported period, inclusive. Cut in the portal time zone in the same way as `startDate`, and  defaults to the moment the call is made. (optional)</param>
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
        /// Returns what the portal spent from its wallet added up per calendar month, so a client can draw a spending  chart without paging through every movement. Only a DocSpace administrator may read it, a portal with no  billing customer answers with an empty result, and the call is read-only. `startDate` and `endDate` bound the  period, both inclusive, and default to the portal creation date and the present moment; the months are cut in  the portal time zone, so a movement at the edge of a month falls where the portal sees it and not where UTC  does. Each item names its year and month, the total charged in it with the currency, and how many operations  that total came from. The movements behind a month are in `GET api/2.0/portal/payment/customer/operations`,  and the same figures as a file come from `POST api/2.0/portal/payment/customer/usage/monthly/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The beginning of the reported period, inclusive. The months are cut in the portal time zone rather than in  UTC, so spending at the turn of a month falls where the portal sees it; defaults to the portal creation date. (optional)</param>
        /// <param name="endDate">The end of the reported period, inclusive. Cut in the portal time zone in the same way as `startDate`, and  defaults to the moment the call is made. (optional)</param>
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
        /// Returns what the portal spent from its wallet added up per calendar month, so a client can draw a spending  chart without paging through every movement. Only a DocSpace administrator may read it, a portal with no  billing customer answers with an empty result, and the call is read-only. `startDate` and `endDate` bound the  period, both inclusive, and default to the portal creation date and the present moment; the months are cut in  the portal time zone, so a movement at the edge of a month falls where the portal sees it and not where UTC  does. Each item names its year and month, the total charged in it with the currency, and how many operations  that total came from. The movements behind a month are in `GET api/2.0/portal/payment/customer/operations`,  and the same figures as a file come from `POST api/2.0/portal/payment/customer/usage/monthly/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The beginning of the reported period, inclusive. The months are cut in the portal time zone rather than in  UTC, so spending at the turn of a month falls where the portal sees it; defaults to the portal creation date. (optional)</param>
        /// <param name="endDate">The end of the reported period, inclusive. Cut in the portal time zone in the same way as `startDate`, and  defaults to the moment the call is made. (optional)</param>
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
        /// Returns what the portal spent from its wallet added up per calendar month, so a client can draw a spending  chart without paging through every movement. Only a DocSpace administrator may read it, a portal with no  billing customer answers with an empty result, and the call is read-only. `startDate` and `endDate` bound the  period, both inclusive, and default to the portal creation date and the present moment; the months are cut in  the portal time zone, so a movement at the edge of a month falls where the portal sees it and not where UTC  does. Each item names its year and month, the total charged in it with the currency, and how many operations  that total came from. The movements behind a month are in `GET api/2.0/portal/payment/customer/operations`,  and the same figures as a file come from `POST api/2.0/portal/payment/customer/usage/monthly/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The beginning of the reported period, inclusive. The months are cut in the portal time zone rather than in  UTC, so spending at the turn of a month falls where the portal sees it; defaults to the portal creation date. (optional)</param>
        /// <param name="endDate">The end of the reported period, inclusive. Cut in the portal time zone in the same way as `startDate`, and  defaults to the moment the call is made. (optional)</param>
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
        /// Get the monthly usage report status
        /// </summary>
        /// <remarks>
        /// Returns the state of the `xlsx` monthly usage report this user started with  `POST api/2.0/portal/payment/customer/usage/monthly/report`: `percentage` while it is being built,  `isCompleted` when it is done, `resultFileId`, `resultFileName` and `resultFileUrl` pointing at the file in  the caller's My documents, and `error` when the build failed. The portal needs a billing customer and the  caller has to be a DocSpace administrator; the call is read-only and is the one to poll. The task is kept per  user and per report kind, so it reports neither another administrator's report nor the operations and service  usage ones, which have their own status operations. An empty result means this user has no monthly usage  report at all - none was started, or the finished one was already picked up or terminated. A completed task is  dropped as soon as the next report is started, so read the file link out of the same answer that first reports  `isCompleted`.
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
        /// Get the monthly usage report status
        /// </summary>
        /// <remarks>
        /// Returns the state of the `xlsx` monthly usage report this user started with  `POST api/2.0/portal/payment/customer/usage/monthly/report`: `percentage` while it is being built,  `isCompleted` when it is done, `resultFileId`, `resultFileName` and `resultFileUrl` pointing at the file in  the caller's My documents, and `error` when the build failed. The portal needs a billing customer and the  caller has to be a DocSpace administrator; the call is read-only and is the one to poll. The task is kept per  user and per report kind, so it reports neither another administrator's report nor the operations and service  usage ones, which have their own status operations. An empty result means this user has no monthly usage  report at all - none was started, or the finished one was already picked up or terminated. A completed task is  dropped as soon as the next report is started, so read the file link out of the same answer that first reports  `isCompleted`.
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
        /// Get the monthly usage report status
        /// </summary>
        /// <remarks>
        /// Returns the state of the `xlsx` monthly usage report this user started with  `POST api/2.0/portal/payment/customer/usage/monthly/report`: `percentage` while it is being built,  `isCompleted` when it is done, `resultFileId`, `resultFileName` and `resultFileUrl` pointing at the file in  the caller's My documents, and `error` when the build failed. The portal needs a billing customer and the  caller has to be a DocSpace administrator; the call is read-only and is the one to poll. The task is kept per  user and per report kind, so it reports neither another administrator's report nor the operations and service  usage ones, which have their own status operations. An empty result means this user has no monthly usage  report at all - none was started, or the finished one was already picked up or terminated. A completed task is  dropped as soon as the next report is started, so read the file link out of the same answer that first reports  `isCompleted`.
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
        /// Get the monthly usage report status
        /// </summary>
        /// <remarks>
        /// Returns the state of the `xlsx` monthly usage report this user started with  `POST api/2.0/portal/payment/customer/usage/monthly/report`: `percentage` while it is being built,  `isCompleted` when it is done, `resultFileId`, `resultFileName` and `resultFileUrl` pointing at the file in  the caller's My documents, and `error` when the build failed. The portal needs a billing customer and the  caller has to be a DocSpace administrator; the call is read-only and is the one to poll. The task is kept per  user and per report kind, so it reports neither another administrator's report nor the operations and service  usage ones, which have their own status operations. An empty result means this user has no monthly usage  report at all - none was started, or the finished one was already picked up or terminated. A completed task is  dropped as soon as the next report is started, so read the file link out of the same answer that first reports  `isCompleted`.
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
        /// Get the wallet operations
        /// </summary>
        /// <remarks>
        /// Lists the money movements on the portal's wallet - top-ups, the charges of the wallet services, refunds and  corrections - one page at a time, which is what a billing history is built from. Only a DocSpace administrator  may read it, a portal with no billing customer answers with an empty result, and the call is read-only. Every  filter is optional: `startDate` and `endDate` are read in the portal time zone and default to the portal  creation date and the present moment, `serviceName` narrows to particular wallet services and fails with 404  on a name this installation does not sell, `participantName`, `type` and `status` narrow to who caused a  movement and how it ended, and `credit` and `debit` include or exclude the two directions. `offset` and  `limit` page through the result and default to 0 and 25, `orderBy` and `orderType` sort it, and the answer  repeats them next to `totalQuantity`, `totalPage` and `currentPage` so a client can page without counting. The  same data as a downloadable file is `POST api/2.0/portal/payment/customer/operationsreport`, and the figures  added up per service are `GET api/2.0/portal/payment/customer/usage`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">The number of movements to skip before the first one returned, for walking through a long history page by  page. Counted after the filters and the ordering are applied, and starts at 0 when omitted. (optional)</param>
        /// <param name="limit">The maximum number of movements returned in one page. Defaults to 25 when omitted; the answer echoes the  window back next to `totalQuantity`, `totalPage` and `currentPage`, so the next `offset` can be computed  without counting the items. (optional)</param>
        /// <param name="serviceName">The wallet services whose movements are kept, named the way the billing catalogue names them - `backup`,  `ai-tools`, `ai-search`, `disk-storage`, `docscloud`. Take the values from the `serviceName` field of  `GET api/2.0/portal/payment/walletservices`; the match ignores case, a name this installation does not sell  fails the call with 404, and an omitted list keeps every service. A bare string is accepted in place of an  array for backward compatibility. (optional)</param>
        /// <param name="startDate">The beginning of the reported period, inclusive. Read in the portal time zone rather than in UTC, so a  movement at the edge of the period falls where the portal sees it; defaults to the portal creation date. (optional)</param>
        /// <param name="endDate">The end of the reported period, inclusive. Read in the portal time zone rather than in UTC, and defaults to  the moment the call is made. (optional)</param>
        /// <param name="participantName">The participant whose movements are kept - the account the accounting service records as the cause of a  movement. A movement caused by a portal user carries that user ID here, and one caused by the portal itself  carries the customer name; surrounding whitespace is trimmed, and an omitted value keeps every participant. (optional)</param>
        /// <param name="credit">Whether movements that add money to the wallet - top-ups, refunds and corrections in the portal's favour -  are kept. Both directions are reported when neither this nor `debit` is given. (optional)</param>
        /// <param name="debit">Whether movements that take money out of the wallet - the charges of the wallet services - are kept. Both  directions are reported when neither this nor `credit` is given. (optional)</param>
        /// <param name="type">The kind of movement to keep, which says what caused the money to move rather than how it ended. Every kind  is reported when it is omitted. (optional)</param>
        /// <param name="status">The outcome to keep. A movement that is still being settled is reported as pending and may change later,  while the other outcomes are final; every outcome is reported when this is omitted. (optional)</param>
        /// <param name="orderBy">The name of the field the movements are sorted by, spelled as the accounting service names it, such as  `StartDate` or `ServiceName`. Surrounding whitespace is trimmed, and the accounting service applies its own  ordering when this is omitted. (optional)</param>
        /// <param name="orderType">The direction the field named in `orderBy` is sorted in. Newest or largest first is what the accounting  service does by default, so leaving this out sorts the same way as asking for descending explicitly. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-operations/">REST API Reference for GetCustomerOperations Operation</seealso>
        /// <returns>ReportWrapper</returns>
        public ReportWrapper GetCustomerOperations(int? offset = default, int? limit = default, List<string>? serviceName = default, DateTime? startDate = default, DateTime? endDate = default, string? participantName = default, bool? credit = default, bool? debit = default, OperationType? type = default, OperationStatus? status = default, string? orderBy = default, OperationOrderType? orderType = default)
        {
            var localVarResponse = GetCustomerOperationsWithHttpInfo(offset, limit, serviceName, startDate, endDate, participantName, credit, debit, type, status, orderBy, orderType);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the wallet operations
        /// </summary>
        /// <remarks>
        /// Lists the money movements on the portal's wallet - top-ups, the charges of the wallet services, refunds and  corrections - one page at a time, which is what a billing history is built from. Only a DocSpace administrator  may read it, a portal with no billing customer answers with an empty result, and the call is read-only. Every  filter is optional: `startDate` and `endDate` are read in the portal time zone and default to the portal  creation date and the present moment, `serviceName` narrows to particular wallet services and fails with 404  on a name this installation does not sell, `participantName`, `type` and `status` narrow to who caused a  movement and how it ended, and `credit` and `debit` include or exclude the two directions. `offset` and  `limit` page through the result and default to 0 and 25, `orderBy` and `orderType` sort it, and the answer  repeats them next to `totalQuantity`, `totalPage` and `currentPage` so a client can page without counting. The  same data as a downloadable file is `POST api/2.0/portal/payment/customer/operationsreport`, and the figures  added up per service are `GET api/2.0/portal/payment/customer/usage`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">The number of movements to skip before the first one returned, for walking through a long history page by  page. Counted after the filters and the ordering are applied, and starts at 0 when omitted. (optional)</param>
        /// <param name="limit">The maximum number of movements returned in one page. Defaults to 25 when omitted; the answer echoes the  window back next to `totalQuantity`, `totalPage` and `currentPage`, so the next `offset` can be computed  without counting the items. (optional)</param>
        /// <param name="serviceName">The wallet services whose movements are kept, named the way the billing catalogue names them - `backup`,  `ai-tools`, `ai-search`, `disk-storage`, `docscloud`. Take the values from the `serviceName` field of  `GET api/2.0/portal/payment/walletservices`; the match ignores case, a name this installation does not sell  fails the call with 404, and an omitted list keeps every service. A bare string is accepted in place of an  array for backward compatibility. (optional)</param>
        /// <param name="startDate">The beginning of the reported period, inclusive. Read in the portal time zone rather than in UTC, so a  movement at the edge of the period falls where the portal sees it; defaults to the portal creation date. (optional)</param>
        /// <param name="endDate">The end of the reported period, inclusive. Read in the portal time zone rather than in UTC, and defaults to  the moment the call is made. (optional)</param>
        /// <param name="participantName">The participant whose movements are kept - the account the accounting service records as the cause of a  movement. A movement caused by a portal user carries that user ID here, and one caused by the portal itself  carries the customer name; surrounding whitespace is trimmed, and an omitted value keeps every participant. (optional)</param>
        /// <param name="credit">Whether movements that add money to the wallet - top-ups, refunds and corrections in the portal's favour -  are kept. Both directions are reported when neither this nor `debit` is given. (optional)</param>
        /// <param name="debit">Whether movements that take money out of the wallet - the charges of the wallet services - are kept. Both  directions are reported when neither this nor `credit` is given. (optional)</param>
        /// <param name="type">The kind of movement to keep, which says what caused the money to move rather than how it ended. Every kind  is reported when it is omitted. (optional)</param>
        /// <param name="status">The outcome to keep. A movement that is still being settled is reported as pending and may change later,  while the other outcomes are final; every outcome is reported when this is omitted. (optional)</param>
        /// <param name="orderBy">The name of the field the movements are sorted by, spelled as the accounting service names it, such as  `StartDate` or `ServiceName`. Surrounding whitespace is trimmed, and the accounting service applies its own  ordering when this is omitted. (optional)</param>
        /// <param name="orderType">The direction the field named in `orderBy` is sorted in. Newest or largest first is what the accounting  service does by default, so leaving this out sorts the same way as asking for descending explicitly. (optional)</param>
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
        /// Get the wallet operations
        /// </summary>
        /// <remarks>
        /// Lists the money movements on the portal's wallet - top-ups, the charges of the wallet services, refunds and  corrections - one page at a time, which is what a billing history is built from. Only a DocSpace administrator  may read it, a portal with no billing customer answers with an empty result, and the call is read-only. Every  filter is optional: `startDate` and `endDate` are read in the portal time zone and default to the portal  creation date and the present moment, `serviceName` narrows to particular wallet services and fails with 404  on a name this installation does not sell, `participantName`, `type` and `status` narrow to who caused a  movement and how it ended, and `credit` and `debit` include or exclude the two directions. `offset` and  `limit` page through the result and default to 0 and 25, `orderBy` and `orderType` sort it, and the answer  repeats them next to `totalQuantity`, `totalPage` and `currentPage` so a client can page without counting. The  same data as a downloadable file is `POST api/2.0/portal/payment/customer/operationsreport`, and the figures  added up per service are `GET api/2.0/portal/payment/customer/usage`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">The number of movements to skip before the first one returned, for walking through a long history page by  page. Counted after the filters and the ordering are applied, and starts at 0 when omitted. (optional)</param>
        /// <param name="limit">The maximum number of movements returned in one page. Defaults to 25 when omitted; the answer echoes the  window back next to `totalQuantity`, `totalPage` and `currentPage`, so the next `offset` can be computed  without counting the items. (optional)</param>
        /// <param name="serviceName">The wallet services whose movements are kept, named the way the billing catalogue names them - `backup`,  `ai-tools`, `ai-search`, `disk-storage`, `docscloud`. Take the values from the `serviceName` field of  `GET api/2.0/portal/payment/walletservices`; the match ignores case, a name this installation does not sell  fails the call with 404, and an omitted list keeps every service. A bare string is accepted in place of an  array for backward compatibility. (optional)</param>
        /// <param name="startDate">The beginning of the reported period, inclusive. Read in the portal time zone rather than in UTC, so a  movement at the edge of the period falls where the portal sees it; defaults to the portal creation date. (optional)</param>
        /// <param name="endDate">The end of the reported period, inclusive. Read in the portal time zone rather than in UTC, and defaults to  the moment the call is made. (optional)</param>
        /// <param name="participantName">The participant whose movements are kept - the account the accounting service records as the cause of a  movement. A movement caused by a portal user carries that user ID here, and one caused by the portal itself  carries the customer name; surrounding whitespace is trimmed, and an omitted value keeps every participant. (optional)</param>
        /// <param name="credit">Whether movements that add money to the wallet - top-ups, refunds and corrections in the portal's favour -  are kept. Both directions are reported when neither this nor `debit` is given. (optional)</param>
        /// <param name="debit">Whether movements that take money out of the wallet - the charges of the wallet services - are kept. Both  directions are reported when neither this nor `credit` is given. (optional)</param>
        /// <param name="type">The kind of movement to keep, which says what caused the money to move rather than how it ended. Every kind  is reported when it is omitted. (optional)</param>
        /// <param name="status">The outcome to keep. A movement that is still being settled is reported as pending and may change later,  while the other outcomes are final; every outcome is reported when this is omitted. (optional)</param>
        /// <param name="orderBy">The name of the field the movements are sorted by, spelled as the accounting service names it, such as  `StartDate` or `ServiceName`. Surrounding whitespace is trimmed, and the accounting service applies its own  ordering when this is omitted. (optional)</param>
        /// <param name="orderType">The direction the field named in `orderBy` is sorted in. Newest or largest first is what the accounting  service does by default, so leaving this out sorts the same way as asking for descending explicitly. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-customer-operations/">REST API Reference for GetCustomerOperations Operation</seealso>
        /// <returns>Task of ReportWrapper</returns>
        public async Task<ReportWrapper> GetCustomerOperationsAsync(int? offset = default, int? limit = default, List<string>? serviceName = default, DateTime? startDate = default, DateTime? endDate = default, string? participantName = default, bool? credit = default, bool? debit = default, OperationType? type = default, OperationStatus? status = default, string? orderBy = default, OperationOrderType? orderType = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetCustomerOperationsWithHttpInfoAsync(offset, limit, serviceName, startDate, endDate, participantName, credit, debit, type, status, orderBy, orderType, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the wallet operations
        /// </summary>
        /// <remarks>
        /// Lists the money movements on the portal's wallet - top-ups, the charges of the wallet services, refunds and  corrections - one page at a time, which is what a billing history is built from. Only a DocSpace administrator  may read it, a portal with no billing customer answers with an empty result, and the call is read-only. Every  filter is optional: `startDate` and `endDate` are read in the portal time zone and default to the portal  creation date and the present moment, `serviceName` narrows to particular wallet services and fails with 404  on a name this installation does not sell, `participantName`, `type` and `status` narrow to who caused a  movement and how it ended, and `credit` and `debit` include or exclude the two directions. `offset` and  `limit` page through the result and default to 0 and 25, `orderBy` and `orderType` sort it, and the answer  repeats them next to `totalQuantity`, `totalPage` and `currentPage` so a client can page without counting. The  same data as a downloadable file is `POST api/2.0/portal/payment/customer/operationsreport`, and the figures  added up per service are `GET api/2.0/portal/payment/customer/usage`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">The number of movements to skip before the first one returned, for walking through a long history page by  page. Counted after the filters and the ordering are applied, and starts at 0 when omitted. (optional)</param>
        /// <param name="limit">The maximum number of movements returned in one page. Defaults to 25 when omitted; the answer echoes the  window back next to `totalQuantity`, `totalPage` and `currentPage`, so the next `offset` can be computed  without counting the items. (optional)</param>
        /// <param name="serviceName">The wallet services whose movements are kept, named the way the billing catalogue names them - `backup`,  `ai-tools`, `ai-search`, `disk-storage`, `docscloud`. Take the values from the `serviceName` field of  `GET api/2.0/portal/payment/walletservices`; the match ignores case, a name this installation does not sell  fails the call with 404, and an omitted list keeps every service. A bare string is accepted in place of an  array for backward compatibility. (optional)</param>
        /// <param name="startDate">The beginning of the reported period, inclusive. Read in the portal time zone rather than in UTC, so a  movement at the edge of the period falls where the portal sees it; defaults to the portal creation date. (optional)</param>
        /// <param name="endDate">The end of the reported period, inclusive. Read in the portal time zone rather than in UTC, and defaults to  the moment the call is made. (optional)</param>
        /// <param name="participantName">The participant whose movements are kept - the account the accounting service records as the cause of a  movement. A movement caused by a portal user carries that user ID here, and one caused by the portal itself  carries the customer name; surrounding whitespace is trimmed, and an omitted value keeps every participant. (optional)</param>
        /// <param name="credit">Whether movements that add money to the wallet - top-ups, refunds and corrections in the portal's favour -  are kept. Both directions are reported when neither this nor `debit` is given. (optional)</param>
        /// <param name="debit">Whether movements that take money out of the wallet - the charges of the wallet services - are kept. Both  directions are reported when neither this nor `credit` is given. (optional)</param>
        /// <param name="type">The kind of movement to keep, which says what caused the money to move rather than how it ended. Every kind  is reported when it is omitted. (optional)</param>
        /// <param name="status">The outcome to keep. A movement that is still being settled is reported as pending and may change later,  while the other outcomes are final; every outcome is reported when this is omitted. (optional)</param>
        /// <param name="orderBy">The name of the field the movements are sorted by, spelled as the accounting service names it, such as  `StartDate` or `ServiceName`. Surrounding whitespace is trimmed, and the accounting service applies its own  ordering when this is omitted. (optional)</param>
        /// <param name="orderType">The direction the field named in `orderBy` is sorted in. Newest or largest first is what the accounting  service does by default, so leaving this out sorts the same way as asking for descending explicitly. (optional)</param>
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
        /// Get the operations report status
        /// </summary>
        /// <remarks>
        /// Returns the state of the `xlsx` wallet operations report this user started with  `POST api/2.0/portal/payment/customer/operationsreport`: `percentage` while it is being built, `isCompleted`  when it is done, `resultFileId`, `resultFileName` and `resultFileUrl` pointing at the file in the caller's My  documents, and `error` when the build failed. The portal needs a billing customer and the caller has to be a  DocSpace administrator; the call is read-only and is the one to poll. The task is kept per user and per report  kind, so it never reports another administrator's report, nor the service usage and monthly usage ones, which  have their own status operations. An empty result means this user has no operations report at all - none was  started, or the finished one was already picked up or terminated. A completed task is dropped as soon as the  next report is started, so read the file link out of the same answer that first reports `isCompleted`.
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
        /// Get the operations report status
        /// </summary>
        /// <remarks>
        /// Returns the state of the `xlsx` wallet operations report this user started with  `POST api/2.0/portal/payment/customer/operationsreport`: `percentage` while it is being built, `isCompleted`  when it is done, `resultFileId`, `resultFileName` and `resultFileUrl` pointing at the file in the caller's My  documents, and `error` when the build failed. The portal needs a billing customer and the caller has to be a  DocSpace administrator; the call is read-only and is the one to poll. The task is kept per user and per report  kind, so it never reports another administrator's report, nor the service usage and monthly usage ones, which  have their own status operations. An empty result means this user has no operations report at all - none was  started, or the finished one was already picked up or terminated. A completed task is dropped as soon as the  next report is started, so read the file link out of the same answer that first reports `isCompleted`.
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
        /// Get the operations report status
        /// </summary>
        /// <remarks>
        /// Returns the state of the `xlsx` wallet operations report this user started with  `POST api/2.0/portal/payment/customer/operationsreport`: `percentage` while it is being built, `isCompleted`  when it is done, `resultFileId`, `resultFileName` and `resultFileUrl` pointing at the file in the caller's My  documents, and `error` when the build failed. The portal needs a billing customer and the caller has to be a  DocSpace administrator; the call is read-only and is the one to poll. The task is kept per user and per report  kind, so it never reports another administrator's report, nor the service usage and monthly usage ones, which  have their own status operations. An empty result means this user has no operations report at all - none was  started, or the finished one was already picked up or terminated. A completed task is dropped as soon as the  next report is started, so read the file link out of the same answer that first reports `isCompleted`.
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
        /// Get the operations report status
        /// </summary>
        /// <remarks>
        /// Returns the state of the `xlsx` wallet operations report this user started with  `POST api/2.0/portal/payment/customer/operationsreport`: `percentage` while it is being built, `isCompleted`  when it is done, `resultFileId`, `resultFileName` and `resultFileUrl` pointing at the file in the caller's My  documents, and `error` when the build failed. The portal needs a billing customer and the caller has to be a  DocSpace administrator; the call is read-only and is the one to poll. The task is kept per user and per report  kind, so it never reports another administrator's report, nor the service usage and monthly usage ones, which  have their own status operations. An empty result means this user has no operations report at all - none was  started, or the finished one was already picked up or terminated. A completed task is dropped as soon as the  next report is started, so read the file link out of the same answer that first reports `isCompleted`.
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
        /// Returns how much of each wallet service the portal consumed and what that cost, added up per service instead  of listed per movement. Only a DocSpace administrator may read it, a portal with no billing customer answers  with an empty result, and the call is read-only. The filters are optional: `serviceName` narrows to particular  services and fails with 404 on a name this installation does not sell, `participantName` and `status` narrow  to who consumed and how the operation ended, `startDate` and `endDate` bound the period in the portal time  zone, `metadata` matches the key and value pairs a service records with its usage, and `offset`, `limit`,  `orderBy` and `orderType` page and sort the result. Amounts come with the unit the service is sold in, except  AI tools, whose consumption is reported in tokens rather than in AI credits. The individual charges behind  these totals are `GET api/2.0/portal/payment/customer/operations`, and the same figures as a downloadable file  are `POST api/2.0/portal/payment/customer/usage/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName">The wallet services whose consumption is added up, named the way the billing catalogue names them -  `backup`, `ai-tools`, `ai-search`, `disk-storage`, `docscloud`. Take the values from the `serviceName` field  of `GET api/2.0/portal/payment/walletservices`; the match ignores case, a name this installation does not  sell fails the call with 404, and an omitted list covers every service. (optional)</param>
        /// <param name="participantName">The participant whose consumption is added up - the account the accounting service records as the consumer.  Consumption caused by a portal user carries that user ID here; surrounding whitespace is trimmed, and an  omitted value covers every participant. (optional)</param>
        /// <param name="status">The outcome to keep. Consumption that is still being settled is reported as pending and may change later,  while the other outcomes are final; every outcome is counted when this is omitted. (optional)</param>
        /// <param name="startDate">The beginning of the reported period, inclusive. Read in the portal time zone rather than in UTC, and  defaults to the portal creation date. (optional)</param>
        /// <param name="endDate">The end of the reported period, inclusive. Read in the portal time zone rather than in UTC, and defaults to  the moment the call is made. (optional)</param>
        /// <param name="metadata">The usage annotations a wallet service records alongside its consumption, as the key and value pairs that  must all match for a record to be counted. The keys are chosen by the service that writes them, so read them  off the `metadata` of the records already returned rather than guessing; an omitted map counts every record. (optional)</param>
        /// <param name="offset">The number of per-service totals to skip before the first one returned. Counted after the filters and the  ordering are applied, and starts at 0 when omitted. (optional)</param>
        /// <param name="limit">The maximum number of per-service totals returned in one page. Defaults to 25 when omitted; the answer echoes  the window back with its paging information, so the next `offset` can be computed without counting the items. (optional)</param>
        /// <param name="orderBy">The name of the field the per-service totals are sorted by, spelled as the accounting service names it, such  as `ServiceName` or `StartDate`. Surrounding whitespace is trimmed, and the accounting service applies its  own ordering when this is omitted. (optional)</param>
        /// <param name="orderType">The direction the field named in `orderBy` is sorted in. Newest or largest first is what the accounting  service does by default, so leaving this out sorts the same way as asking for descending explicitly. (optional)</param>
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
        /// Returns how much of each wallet service the portal consumed and what that cost, added up per service instead  of listed per movement. Only a DocSpace administrator may read it, a portal with no billing customer answers  with an empty result, and the call is read-only. The filters are optional: `serviceName` narrows to particular  services and fails with 404 on a name this installation does not sell, `participantName` and `status` narrow  to who consumed and how the operation ended, `startDate` and `endDate` bound the period in the portal time  zone, `metadata` matches the key and value pairs a service records with its usage, and `offset`, `limit`,  `orderBy` and `orderType` page and sort the result. Amounts come with the unit the service is sold in, except  AI tools, whose consumption is reported in tokens rather than in AI credits. The individual charges behind  these totals are `GET api/2.0/portal/payment/customer/operations`, and the same figures as a downloadable file  are `POST api/2.0/portal/payment/customer/usage/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName">The wallet services whose consumption is added up, named the way the billing catalogue names them -  `backup`, `ai-tools`, `ai-search`, `disk-storage`, `docscloud`. Take the values from the `serviceName` field  of `GET api/2.0/portal/payment/walletservices`; the match ignores case, a name this installation does not  sell fails the call with 404, and an omitted list covers every service. (optional)</param>
        /// <param name="participantName">The participant whose consumption is added up - the account the accounting service records as the consumer.  Consumption caused by a portal user carries that user ID here; surrounding whitespace is trimmed, and an  omitted value covers every participant. (optional)</param>
        /// <param name="status">The outcome to keep. Consumption that is still being settled is reported as pending and may change later,  while the other outcomes are final; every outcome is counted when this is omitted. (optional)</param>
        /// <param name="startDate">The beginning of the reported period, inclusive. Read in the portal time zone rather than in UTC, and  defaults to the portal creation date. (optional)</param>
        /// <param name="endDate">The end of the reported period, inclusive. Read in the portal time zone rather than in UTC, and defaults to  the moment the call is made. (optional)</param>
        /// <param name="metadata">The usage annotations a wallet service records alongside its consumption, as the key and value pairs that  must all match for a record to be counted. The keys are chosen by the service that writes them, so read them  off the `metadata` of the records already returned rather than guessing; an omitted map counts every record. (optional)</param>
        /// <param name="offset">The number of per-service totals to skip before the first one returned. Counted after the filters and the  ordering are applied, and starts at 0 when omitted. (optional)</param>
        /// <param name="limit">The maximum number of per-service totals returned in one page. Defaults to 25 when omitted; the answer echoes  the window back with its paging information, so the next `offset` can be computed without counting the items. (optional)</param>
        /// <param name="orderBy">The name of the field the per-service totals are sorted by, spelled as the accounting service names it, such  as `ServiceName` or `StartDate`. Surrounding whitespace is trimmed, and the accounting service applies its  own ordering when this is omitted. (optional)</param>
        /// <param name="orderType">The direction the field named in `orderBy` is sorted in. Newest or largest first is what the accounting  service does by default, so leaving this out sorts the same way as asking for descending explicitly. (optional)</param>
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
        /// Returns how much of each wallet service the portal consumed and what that cost, added up per service instead  of listed per movement. Only a DocSpace administrator may read it, a portal with no billing customer answers  with an empty result, and the call is read-only. The filters are optional: `serviceName` narrows to particular  services and fails with 404 on a name this installation does not sell, `participantName` and `status` narrow  to who consumed and how the operation ended, `startDate` and `endDate` bound the period in the portal time  zone, `metadata` matches the key and value pairs a service records with its usage, and `offset`, `limit`,  `orderBy` and `orderType` page and sort the result. Amounts come with the unit the service is sold in, except  AI tools, whose consumption is reported in tokens rather than in AI credits. The individual charges behind  these totals are `GET api/2.0/portal/payment/customer/operations`, and the same figures as a downloadable file  are `POST api/2.0/portal/payment/customer/usage/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName">The wallet services whose consumption is added up, named the way the billing catalogue names them -  `backup`, `ai-tools`, `ai-search`, `disk-storage`, `docscloud`. Take the values from the `serviceName` field  of `GET api/2.0/portal/payment/walletservices`; the match ignores case, a name this installation does not  sell fails the call with 404, and an omitted list covers every service. (optional)</param>
        /// <param name="participantName">The participant whose consumption is added up - the account the accounting service records as the consumer.  Consumption caused by a portal user carries that user ID here; surrounding whitespace is trimmed, and an  omitted value covers every participant. (optional)</param>
        /// <param name="status">The outcome to keep. Consumption that is still being settled is reported as pending and may change later,  while the other outcomes are final; every outcome is counted when this is omitted. (optional)</param>
        /// <param name="startDate">The beginning of the reported period, inclusive. Read in the portal time zone rather than in UTC, and  defaults to the portal creation date. (optional)</param>
        /// <param name="endDate">The end of the reported period, inclusive. Read in the portal time zone rather than in UTC, and defaults to  the moment the call is made. (optional)</param>
        /// <param name="metadata">The usage annotations a wallet service records alongside its consumption, as the key and value pairs that  must all match for a record to be counted. The keys are chosen by the service that writes them, so read them  off the `metadata` of the records already returned rather than guessing; an omitted map counts every record. (optional)</param>
        /// <param name="offset">The number of per-service totals to skip before the first one returned. Counted after the filters and the  ordering are applied, and starts at 0 when omitted. (optional)</param>
        /// <param name="limit">The maximum number of per-service totals returned in one page. Defaults to 25 when omitted; the answer echoes  the window back with its paging information, so the next `offset` can be computed without counting the items. (optional)</param>
        /// <param name="orderBy">The name of the field the per-service totals are sorted by, spelled as the accounting service names it, such  as `ServiceName` or `StartDate`. Surrounding whitespace is trimmed, and the accounting service applies its  own ordering when this is omitted. (optional)</param>
        /// <param name="orderType">The direction the field named in `orderBy` is sorted in. Newest or largest first is what the accounting  service does by default, so leaving this out sorts the same way as asking for descending explicitly. (optional)</param>
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
        /// Returns how much of each wallet service the portal consumed and what that cost, added up per service instead  of listed per movement. Only a DocSpace administrator may read it, a portal with no billing customer answers  with an empty result, and the call is read-only. The filters are optional: `serviceName` narrows to particular  services and fails with 404 on a name this installation does not sell, `participantName` and `status` narrow  to who consumed and how the operation ended, `startDate` and `endDate` bound the period in the portal time  zone, `metadata` matches the key and value pairs a service records with its usage, and `offset`, `limit`,  `orderBy` and `orderType` page and sort the result. Amounts come with the unit the service is sold in, except  AI tools, whose consumption is reported in tokens rather than in AI credits. The individual charges behind  these totals are `GET api/2.0/portal/payment/customer/operations`, and the same figures as a downloadable file  are `POST api/2.0/portal/payment/customer/usage/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName">The wallet services whose consumption is added up, named the way the billing catalogue names them -  `backup`, `ai-tools`, `ai-search`, `disk-storage`, `docscloud`. Take the values from the `serviceName` field  of `GET api/2.0/portal/payment/walletservices`; the match ignores case, a name this installation does not  sell fails the call with 404, and an omitted list covers every service. (optional)</param>
        /// <param name="participantName">The participant whose consumption is added up - the account the accounting service records as the consumer.  Consumption caused by a portal user carries that user ID here; surrounding whitespace is trimmed, and an  omitted value covers every participant. (optional)</param>
        /// <param name="status">The outcome to keep. Consumption that is still being settled is reported as pending and may change later,  while the other outcomes are final; every outcome is counted when this is omitted. (optional)</param>
        /// <param name="startDate">The beginning of the reported period, inclusive. Read in the portal time zone rather than in UTC, and  defaults to the portal creation date. (optional)</param>
        /// <param name="endDate">The end of the reported period, inclusive. Read in the portal time zone rather than in UTC, and defaults to  the moment the call is made. (optional)</param>
        /// <param name="metadata">The usage annotations a wallet service records alongside its consumption, as the key and value pairs that  must all match for a record to be counted. The keys are chosen by the service that writes them, so read them  off the `metadata` of the records already returned rather than guessing; an omitted map counts every record. (optional)</param>
        /// <param name="offset">The number of per-service totals to skip before the first one returned. Counted after the filters and the  ordering are applied, and starts at 0 when omitted. (optional)</param>
        /// <param name="limit">The maximum number of per-service totals returned in one page. Defaults to 25 when omitted; the answer echoes  the window back with its paging information, so the next `offset` can be computed without counting the items. (optional)</param>
        /// <param name="orderBy">The name of the field the per-service totals are sorted by, spelled as the accounting service names it, such  as `ServiceName` or `StartDate`. Surrounding whitespace is trimmed, and the accounting service applies its  own ordering when this is omitted. (optional)</param>
        /// <param name="orderType">The direction the field named in `orderBy` is sorted in. Newest or largest first is what the accounting  service does by default, so leaving this out sorts the same way as asking for descending explicitly. (optional)</param>
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
        /// Get the service usage report status
        /// </summary>
        /// <remarks>
        /// Returns the state of the `xlsx` service usage report this user started with  `POST api/2.0/portal/payment/customer/usage/report`: `percentage` while it is being built, `isCompleted` when  it is done, `resultFileId`, `resultFileName` and `resultFileUrl` pointing at the file in the caller's My  documents, and `error` when the build failed. The portal needs a billing customer and the caller has to be a  DocSpace administrator; the call is read-only and is the one to poll. The task is kept per user and per report  kind, so it reports neither another administrator's report nor the operations and monthly usage ones, which  have their own status operations. An empty result means this user has no service usage report at all - none  was started, or the finished one was already picked up or terminated. A completed task is dropped as soon as  the next report is started, so read the file link out of the same answer that first reports `isCompleted`.
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
        /// Get the service usage report status
        /// </summary>
        /// <remarks>
        /// Returns the state of the `xlsx` service usage report this user started with  `POST api/2.0/portal/payment/customer/usage/report`: `percentage` while it is being built, `isCompleted` when  it is done, `resultFileId`, `resultFileName` and `resultFileUrl` pointing at the file in the caller's My  documents, and `error` when the build failed. The portal needs a billing customer and the caller has to be a  DocSpace administrator; the call is read-only and is the one to poll. The task is kept per user and per report  kind, so it reports neither another administrator's report nor the operations and monthly usage ones, which  have their own status operations. An empty result means this user has no service usage report at all - none  was started, or the finished one was already picked up or terminated. A completed task is dropped as soon as  the next report is started, so read the file link out of the same answer that first reports `isCompleted`.
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
        /// Get the service usage report status
        /// </summary>
        /// <remarks>
        /// Returns the state of the `xlsx` service usage report this user started with  `POST api/2.0/portal/payment/customer/usage/report`: `percentage` while it is being built, `isCompleted` when  it is done, `resultFileId`, `resultFileName` and `resultFileUrl` pointing at the file in the caller's My  documents, and `error` when the build failed. The portal needs a billing customer and the caller has to be a  DocSpace administrator; the call is read-only and is the one to poll. The task is kept per user and per report  kind, so it reports neither another administrator's report nor the operations and monthly usage ones, which  have their own status operations. An empty result means this user has no service usage report at all - none  was started, or the finished one was already picked up or terminated. A completed task is dropped as soon as  the next report is started, so read the file link out of the same answer that first reports `isCompleted`.
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
        /// Get the service usage report status
        /// </summary>
        /// <remarks>
        /// Returns the state of the `xlsx` service usage report this user started with  `POST api/2.0/portal/payment/customer/usage/report`: `percentage` while it is being built, `isCompleted` when  it is done, `resultFileId`, `resultFileName` and `resultFileUrl` pointing at the file in the caller's My  documents, and `error` when the build failed. The portal needs a billing customer and the caller has to be a  DocSpace administrator; the call is read-only and is the one to poll. The task is kept per user and per report  kind, so it reports neither another administrator's report nor the operations and monthly usage ones, which  have their own status operations. An empty result means this user has no service usage report at all - none  was started, or the finished one was already picked up or terminated. A completed task is dropped as soon as  the next report is started, so read the file link out of the same answer that first reports `isCompleted`.
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
        /// Get the billing account page
        /// </summary>
        /// <remarks>
        /// Hands back the address of the portal page on which the billing account is managed - the payment method on  file, the invoices and the receipts - so a client can link to it instead of assembling the address itself. The  portal must already have a billing customer: one that has never had it gets an empty result, and an  installation without a billing service answers 403. Only the payer or the portal owner may read it, and the  call changes nothing. The value is relative to the portal root (`payment.ashx`), and the optional `backUrl` is  appended to it as a query parameter so the page can send the user back where they came from. It is not a  checkout page: a plan is bought with `PUT api/2.0/portal/payment/url` and a payment method is attached with  `GET api/2.0/portal/payment/checkoutsetupurl`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">The absolute address the billing account page should offer as its way back. It is appended to the returned  portal-relative address as a query parameter rather than followed here, and omitting it yields the bare  address of the page. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-account/">REST API Reference for GetPaymentAccount Operation</seealso>
        /// <returns>StringWrapper</returns>
        public StringWrapper GetPaymentAccount(string? backUrl = default)
        {
            var localVarResponse = GetPaymentAccountWithHttpInfo(backUrl);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the billing account page
        /// </summary>
        /// <remarks>
        /// Hands back the address of the portal page on which the billing account is managed - the payment method on  file, the invoices and the receipts - so a client can link to it instead of assembling the address itself. The  portal must already have a billing customer: one that has never had it gets an empty result, and an  installation without a billing service answers 403. Only the payer or the portal owner may read it, and the  call changes nothing. The value is relative to the portal root (`payment.ashx`), and the optional `backUrl` is  appended to it as a query parameter so the page can send the user back where they came from. It is not a  checkout page: a plan is bought with `PUT api/2.0/portal/payment/url` and a payment method is attached with  `GET api/2.0/portal/payment/checkoutsetupurl`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">The absolute address the billing account page should offer as its way back. It is appended to the returned  portal-relative address as a query parameter rather than followed here, and omitting it yields the bare  address of the page. (optional)</param>
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
        /// Get the billing account page
        /// </summary>
        /// <remarks>
        /// Hands back the address of the portal page on which the billing account is managed - the payment method on  file, the invoices and the receipts - so a client can link to it instead of assembling the address itself. The  portal must already have a billing customer: one that has never had it gets an empty result, and an  installation without a billing service answers 403. Only the payer or the portal owner may read it, and the  call changes nothing. The value is relative to the portal root (`payment.ashx`), and the optional `backUrl` is  appended to it as a query parameter so the page can send the user back where they came from. It is not a  checkout page: a plan is bought with `PUT api/2.0/portal/payment/url` and a payment method is attached with  `GET api/2.0/portal/payment/checkoutsetupurl`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">The absolute address the billing account page should offer as its way back. It is appended to the returned  portal-relative address as a query parameter rather than followed here, and omitting it yields the bare  address of the page. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-account/">REST API Reference for GetPaymentAccount Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        public async Task<StringWrapper> GetPaymentAccountAsync(string? backUrl = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetPaymentAccountWithHttpInfoAsync(backUrl, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the billing account page
        /// </summary>
        /// <remarks>
        /// Hands back the address of the portal page on which the billing account is managed - the payment method on  file, the invoices and the receipts - so a client can link to it instead of assembling the address itself. The  portal must already have a billing customer: one that has never had it gets an empty result, and an  installation without a billing service answers 403. Only the payer or the portal owner may read it, and the  call changes nothing. The value is relative to the portal root (`payment.ashx`), and the optional `backUrl` is  appended to it as a query parameter so the page can send the user back where they came from. It is not a  checkout page: a plan is bought with `PUT api/2.0/portal/payment/url` and a payment method is attached with  `GET api/2.0/portal/payment/checkoutsetupurl`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="backUrl">The absolute address the billing account page should offer as its way back. It is appended to the returned  portal-relative address as a query parameter rather than followed here, and omitting it yields the bare  address of the page. (optional)</param>
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
        /// Get the billing currencies
        /// </summary>
        /// <remarks>
        /// Tells a client which currency the portal is billed in: the default currency of the portal region always comes  first, followed by the currency resolved for the current request when that one differs, so the answer holds  one or two items. Nothing has to be called first, the caller needs the permission to edit the portal settings,  and the call is read-only. Each item carries the country code of the region, the currency symbol and the  native name of the currency; the first item is the currency the amounts from  `GET api/2.0/portal/payment/prices` are expressed in. These are the currencies of the subscription prices, and  they are not the accounting currencies the wallet is topped up in - those come with the balance in  `GET api/2.0/portal/payment/customer/balance`.
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
        /// Get the billing currencies
        /// </summary>
        /// <remarks>
        /// Tells a client which currency the portal is billed in: the default currency of the portal region always comes  first, followed by the currency resolved for the current request when that one differs, so the answer holds  one or two items. Nothing has to be called first, the caller needs the permission to edit the portal settings,  and the call is read-only. Each item carries the country code of the region, the currency symbol and the  native name of the currency; the first item is the currency the amounts from  `GET api/2.0/portal/payment/prices` are expressed in. These are the currencies of the subscription prices, and  they are not the accounting currencies the wallet is topped up in - those come with the balance in  `GET api/2.0/portal/payment/customer/balance`.
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
        /// Get the billing currencies
        /// </summary>
        /// <remarks>
        /// Tells a client which currency the portal is billed in: the default currency of the portal region always comes  first, followed by the currency resolved for the current request when that one differs, so the answer holds  one or two items. Nothing has to be called first, the caller needs the permission to edit the portal settings,  and the call is read-only. Each item carries the country code of the region, the currency symbol and the  native name of the currency; the first item is the currency the amounts from  `GET api/2.0/portal/payment/prices` are expressed in. These are the currencies of the subscription prices, and  they are not the accounting currencies the wallet is topped up in - those come with the balance in  `GET api/2.0/portal/payment/customer/balance`.
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
        /// Get the billing currencies
        /// </summary>
        /// <remarks>
        /// Tells a client which currency the portal is billed in: the default currency of the portal region always comes  first, followed by the currency resolved for the current request when that one differs, so the answer holds  one or two items. Nothing has to be called first, the caller needs the permission to edit the portal settings,  and the call is read-only. Each item carries the country code of the region, the currency symbol and the  native name of the currency; the first item is the currency the amounts from  `GET api/2.0/portal/payment/prices` are expressed in. These are the currencies of the subscription prices, and  they are not the accounting currencies the wallet is topped up in - those come with the balance in  `GET api/2.0/portal/payment/customer/balance`.
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
        /// Get the purchasable quotas
        /// </summary>
        /// <remarks>
        /// Lists the quotas the portal can be put on - the paid plans and the wallet services - each with its price, its  features and the limits it grants, which is what a pricing page is built from. Nothing has to be called first,  the caller needs the permission to edit the portal settings, and the call is read-only. Only quotas marked  visible are listed, newest first, and the two optional filters narrow that: `wallet` selects the wallet  services (`true`) or the subscription plans (`false`), `additional` selects the add-ons to a plan (`true`) or  the plans themselves (`false`), and an omitted filter keeps both kinds. A portal on a non-profit quota is a  special case - asking for `additional=false` returns that single quota and nothing else, because no other plan  may be bought for it. The quota the portal is actually on is not marked here; read it from  `GET api/2.0/portal/payment/quota`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wallet">Which side of the catalogue is listed: `true` keeps the services paid out of the portal wallet, `false` keeps  the subscription plans, and omitting it keeps both. (optional)</param>
        /// <param name="additional">Which layer of the catalogue is listed: `true` keeps the add-ons that extend a plan, `false` keeps the plans  themselves, and omitting it keeps both. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-quotas/">REST API Reference for GetPaymentQuotas Operation</seealso>
        /// <returns>QuotaArrayWrapper</returns>
        public QuotaArrayWrapper GetPaymentQuotas(bool? wallet = default, bool? additional = default)
        {
            var localVarResponse = GetPaymentQuotasWithHttpInfo(wallet, additional);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the purchasable quotas
        /// </summary>
        /// <remarks>
        /// Lists the quotas the portal can be put on - the paid plans and the wallet services - each with its price, its  features and the limits it grants, which is what a pricing page is built from. Nothing has to be called first,  the caller needs the permission to edit the portal settings, and the call is read-only. Only quotas marked  visible are listed, newest first, and the two optional filters narrow that: `wallet` selects the wallet  services (`true`) or the subscription plans (`false`), `additional` selects the add-ons to a plan (`true`) or  the plans themselves (`false`), and an omitted filter keeps both kinds. A portal on a non-profit quota is a  special case - asking for `additional=false` returns that single quota and nothing else, because no other plan  may be bought for it. The quota the portal is actually on is not marked here; read it from  `GET api/2.0/portal/payment/quota`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wallet">Which side of the catalogue is listed: `true` keeps the services paid out of the portal wallet, `false` keeps  the subscription plans, and omitting it keeps both. (optional)</param>
        /// <param name="additional">Which layer of the catalogue is listed: `true` keeps the add-ons that extend a plan, `false` keeps the plans  themselves, and omitting it keeps both. (optional)</param>
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
        /// Get the purchasable quotas
        /// </summary>
        /// <remarks>
        /// Lists the quotas the portal can be put on - the paid plans and the wallet services - each with its price, its  features and the limits it grants, which is what a pricing page is built from. Nothing has to be called first,  the caller needs the permission to edit the portal settings, and the call is read-only. Only quotas marked  visible are listed, newest first, and the two optional filters narrow that: `wallet` selects the wallet  services (`true`) or the subscription plans (`false`), `additional` selects the add-ons to a plan (`true`) or  the plans themselves (`false`), and an omitted filter keeps both kinds. A portal on a non-profit quota is a  special case - asking for `additional=false` returns that single quota and nothing else, because no other plan  may be bought for it. The quota the portal is actually on is not marked here; read it from  `GET api/2.0/portal/payment/quota`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wallet">Which side of the catalogue is listed: `true` keeps the services paid out of the portal wallet, `false` keeps  the subscription plans, and omitting it keeps both. (optional)</param>
        /// <param name="additional">Which layer of the catalogue is listed: `true` keeps the add-ons that extend a plan, `false` keeps the plans  themselves, and omitting it keeps both. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-quotas/">REST API Reference for GetPaymentQuotas Operation</seealso>
        /// <returns>Task of QuotaArrayWrapper</returns>
        public async Task<QuotaArrayWrapper> GetPaymentQuotasAsync(bool? wallet = default, bool? additional = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetPaymentQuotasWithHttpInfoAsync(wallet, additional, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the purchasable quotas
        /// </summary>
        /// <remarks>
        /// Lists the quotas the portal can be put on - the paid plans and the wallet services - each with its price, its  features and the limits it grants, which is what a pricing page is built from. Nothing has to be called first,  the caller needs the permission to edit the portal settings, and the call is read-only. Only quotas marked  visible are listed, newest first, and the two optional filters narrow that: `wallet` selects the wallet  services (`true`) or the subscription plans (`false`), `additional` selects the add-ons to a plan (`true`) or  the plans themselves (`false`), and an omitted filter keeps both kinds. A portal on a non-profit quota is a  special case - asking for `additional=false` returns that single quota and nothing else, because no other plan  may be bought for it. The quota the portal is actually on is not marked here; read it from  `GET api/2.0/portal/payment/quota`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wallet">Which side of the catalogue is listed: `true` keeps the services paid out of the portal wallet, `false` keeps  the subscription plans, and omitting it keeps both. (optional)</param>
        /// <param name="additional">Which layer of the catalogue is listed: `true` keeps the add-ons that extend a plan, `false` keeps the plans  themselves, and omitting it keeps both. (optional)</param>
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
        /// Starts the purchase of a monthly paid plan for this portal by handing back the hosted checkout page the buyer  has to open; nothing is bought until that page is completed. The portal must have no paid plan yet - a portal  whose plan is already paid gets an empty result and changes its subscription through  `PUT api/2.0/portal/payment/update` instead - and the product name in `quantity` must be one of the monthly,  non-wallet plans listed by `GET api/2.0/portal/payment/quotas`. Only a DocSpace administrator may call it. The  call itself changes nothing on the portal and may be repeated: the money is taken by the payment provider on  the checkout page, and the plan becomes active once the provider confirms it. The returned URL is absolute and  single-purpose - it carries the caller's e-mail, the language of the request and the currency of the request  region, and it redirects to `successUrl` or `backUrl` when the buyer finishes or cancels. Exactly one product  per call is accepted and its quantity has to be greater than zero; yearly and wallet products are refused, and  wallet services are bought with `PUT api/2.0/portal/payment/updatewallet` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentUrlRequestDto">The plan being bought and the two pages the hosted checkout returns the buyer to. (optional)</param>
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
        /// Starts the purchase of a monthly paid plan for this portal by handing back the hosted checkout page the buyer  has to open; nothing is bought until that page is completed. The portal must have no paid plan yet - a portal  whose plan is already paid gets an empty result and changes its subscription through  `PUT api/2.0/portal/payment/update` instead - and the product name in `quantity` must be one of the monthly,  non-wallet plans listed by `GET api/2.0/portal/payment/quotas`. Only a DocSpace administrator may call it. The  call itself changes nothing on the portal and may be repeated: the money is taken by the payment provider on  the checkout page, and the plan becomes active once the provider confirms it. The returned URL is absolute and  single-purpose - it carries the caller's e-mail, the language of the request and the currency of the request  region, and it redirects to `successUrl` or `backUrl` when the buyer finishes or cancels. Exactly one product  per call is accepted and its quantity has to be greater than zero; yearly and wallet products are refused, and  wallet services are bought with `PUT api/2.0/portal/payment/updatewallet` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentUrlRequestDto">The plan being bought and the two pages the hosted checkout returns the buyer to. (optional)</param>
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
        /// Starts the purchase of a monthly paid plan for this portal by handing back the hosted checkout page the buyer  has to open; nothing is bought until that page is completed. The portal must have no paid plan yet - a portal  whose plan is already paid gets an empty result and changes its subscription through  `PUT api/2.0/portal/payment/update` instead - and the product name in `quantity` must be one of the monthly,  non-wallet plans listed by `GET api/2.0/portal/payment/quotas`. Only a DocSpace administrator may call it. The  call itself changes nothing on the portal and may be repeated: the money is taken by the payment provider on  the checkout page, and the plan becomes active once the provider confirms it. The returned URL is absolute and  single-purpose - it carries the caller's e-mail, the language of the request and the currency of the request  region, and it redirects to `successUrl` or `backUrl` when the buyer finishes or cancels. Exactly one product  per call is accepted and its quantity has to be greater than zero; yearly and wallet products are refused, and  wallet services are bought with `PUT api/2.0/portal/payment/updatewallet` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentUrlRequestDto">The plan being bought and the two pages the hosted checkout returns the buyer to. (optional)</param>
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
        /// Starts the purchase of a monthly paid plan for this portal by handing back the hosted checkout page the buyer  has to open; nothing is bought until that page is completed. The portal must have no paid plan yet - a portal  whose plan is already paid gets an empty result and changes its subscription through  `PUT api/2.0/portal/payment/update` instead - and the product name in `quantity` must be one of the monthly,  non-wallet plans listed by `GET api/2.0/portal/payment/quotas`. Only a DocSpace administrator may call it. The  call itself changes nothing on the portal and may be repeated: the money is taken by the payment provider on  the checkout page, and the plan becomes active once the provider confirms it. The returned URL is absolute and  single-purpose - it carries the caller's e-mail, the language of the request and the currency of the request  region, and it redirects to `successUrl` or `backUrl` when the buyer finishes or cancels. Exactly one product  per call is accepted and its quantity has to be greater than zero; yearly and wallet products are refused, and  wallet services are bought with `PUT api/2.0/portal/payment/updatewallet` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentUrlRequestDto">The plan being bought and the two pages the hosted checkout returns the buyer to. (optional)</param>
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
        /// Get the product prices
        /// </summary>
        /// <remarks>
        /// Lists what one unit of every purchasable product costs, keyed by the product name that `quantity` takes in the  purchase operations, so a client can price a plan or a wallet service without reading the whole quota list.  Nothing has to be called first, and the caller needs the permission to edit the portal settings, which portal  administrators and the owner have. The call is read-only. Prices are given in the one currency resolved for  this request from the portal region, which `GET api/2.0/portal/payment/currencies` reports; a product with no  price in that currency comes back as `0` rather than being left out, so a zero means unpriced and not free.  The list covers the products on offer, not the portal's own plan - the plan in force, with its limits and its  usage, is `GET api/2.0/portal/payment/quota`.
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
        /// Get the product prices
        /// </summary>
        /// <remarks>
        /// Lists what one unit of every purchasable product costs, keyed by the product name that `quantity` takes in the  purchase operations, so a client can price a plan or a wallet service without reading the whole quota list.  Nothing has to be called first, and the caller needs the permission to edit the portal settings, which portal  administrators and the owner have. The call is read-only. Prices are given in the one currency resolved for  this request from the portal region, which `GET api/2.0/portal/payment/currencies` reports; a product with no  price in that currency comes back as `0` rather than being left out, so a zero means unpriced and not free.  The list covers the products on offer, not the portal's own plan - the plan in force, with its limits and its  usage, is `GET api/2.0/portal/payment/quota`.
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
        /// Get the product prices
        /// </summary>
        /// <remarks>
        /// Lists what one unit of every purchasable product costs, keyed by the product name that `quantity` takes in the  purchase operations, so a client can price a plan or a wallet service without reading the whole quota list.  Nothing has to be called first, and the caller needs the permission to edit the portal settings, which portal  administrators and the owner have. The call is read-only. Prices are given in the one currency resolved for  this request from the portal region, which `GET api/2.0/portal/payment/currencies` reports; a product with no  price in that currency comes back as `0` rather than being left out, so a zero means unpriced and not free.  The list covers the products on offer, not the portal's own plan - the plan in force, with its limits and its  usage, is `GET api/2.0/portal/payment/quota`.
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
        /// Get the product prices
        /// </summary>
        /// <remarks>
        /// Lists what one unit of every purchasable product costs, keyed by the product name that `quantity` takes in the  purchase operations, so a client can price a plan or a wallet service without reading the whole quota list.  Nothing has to be called first, and the caller needs the permission to edit the portal settings, which portal  administrators and the owner have. The call is read-only. Prices are given in the one currency resolved for  this request from the portal region, which `GET api/2.0/portal/payment/currencies` reports; a product with no  price in that currency comes back as `0` rather than being left out, so a zero means unpriced and not free.  The list covers the products on offer, not the portal's own plan - the plan in force, with its limits and its  usage, is `GET api/2.0/portal/payment/quota`.
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
        /// Get the current plan and limits
        /// </summary>
        /// <remarks>
        /// Returns the quota the portal is on right now - its paid plan or the free one - with everything a client needs  to render itself: the price, the features that are switched on, the limits they grant (rooms, storage in  bytes, users, administrators, AI) and how much of each is already used. Every signed-in member of the portal  reads it, so it is not restricted to administrators; only guests are refused with 403. The call is read-only.  The plan is served from the cache by default, which is what a start-up needs; `refresh=true` fetches it from  the billing service instead, so use that right after a purchase and not routinely, because it is a remote  call. The catalogue of the quotas that could be bought instead is `GET api/2.0/portal/payment/quotas`, and the  money side of the same portal - customer, wallet and balance - starts at  `GET api/2.0/portal/payment/customerinfo`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Whether the answer is fetched from the billing service instead of the portal cache. The cached copy is what a  start-up needs and costs nothing; asking for a fresh one makes a remote call, so use it right after a  purchase or a top-up and not on every read. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-quota-payment-information/">REST API Reference for GetQuotaPaymentInformation Operation</seealso>
        /// <returns>QuotaWrapper</returns>
        public QuotaWrapper GetQuotaPaymentInformation(bool? refresh = default)
        {
            var localVarResponse = GetQuotaPaymentInformationWithHttpInfo(refresh);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the current plan and limits
        /// </summary>
        /// <remarks>
        /// Returns the quota the portal is on right now - its paid plan or the free one - with everything a client needs  to render itself: the price, the features that are switched on, the limits they grant (rooms, storage in  bytes, users, administrators, AI) and how much of each is already used. Every signed-in member of the portal  reads it, so it is not restricted to administrators; only guests are refused with 403. The call is read-only.  The plan is served from the cache by default, which is what a start-up needs; `refresh=true` fetches it from  the billing service instead, so use that right after a purchase and not routinely, because it is a remote  call. The catalogue of the quotas that could be bought instead is `GET api/2.0/portal/payment/quotas`, and the  money side of the same portal - customer, wallet and balance - starts at  `GET api/2.0/portal/payment/customerinfo`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Whether the answer is fetched from the billing service instead of the portal cache. The cached copy is what a  start-up needs and costs nothing; asking for a fresh one makes a remote call, so use it right after a  purchase or a top-up and not on every read. (optional)</param>
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
        /// Get the current plan and limits
        /// </summary>
        /// <remarks>
        /// Returns the quota the portal is on right now - its paid plan or the free one - with everything a client needs  to render itself: the price, the features that are switched on, the limits they grant (rooms, storage in  bytes, users, administrators, AI) and how much of each is already used. Every signed-in member of the portal  reads it, so it is not restricted to administrators; only guests are refused with 403. The call is read-only.  The plan is served from the cache by default, which is what a start-up needs; `refresh=true` fetches it from  the billing service instead, so use that right after a purchase and not routinely, because it is a remote  call. The catalogue of the quotas that could be bought instead is `GET api/2.0/portal/payment/quotas`, and the  money side of the same portal - customer, wallet and balance - starts at  `GET api/2.0/portal/payment/customerinfo`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Whether the answer is fetched from the billing service instead of the portal cache. The cached copy is what a  start-up needs and costs nothing; asking for a fresh one makes a remote call, so use it right after a  purchase or a top-up and not on every read. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-quota-payment-information/">REST API Reference for GetQuotaPaymentInformation Operation</seealso>
        /// <returns>Task of QuotaWrapper</returns>
        public async Task<QuotaWrapper> GetQuotaPaymentInformationAsync(bool? refresh = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetQuotaPaymentInformationWithHttpInfoAsync(refresh, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the current plan and limits
        /// </summary>
        /// <remarks>
        /// Returns the quota the portal is on right now - its paid plan or the free one - with everything a client needs  to render itself: the price, the features that are switched on, the limits they grant (rooms, storage in  bytes, users, administrators, AI) and how much of each is already used. Every signed-in member of the portal  reads it, so it is not restricted to administrators; only guests are refused with 403. The call is read-only.  The plan is served from the cache by default, which is what a start-up needs; `refresh=true` fetches it from  the billing service instead, so use that right after a purchase and not routinely, because it is a remote  call. The catalogue of the quotas that could be bought instead is `GET api/2.0/portal/payment/quotas`, and the  money side of the same portal - customer, wallet and balance - starts at  `GET api/2.0/portal/payment/customerinfo`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refresh">Whether the answer is fetched from the billing service instead of the portal cache. The cached copy is what a  start-up needs and costs nothing; asking for a fresh one makes a remote call, so use it right after a  purchase or a top-up and not on every read. (optional)</param>
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
        /// Returns the AI chat models that are barred on this portal - the ones no user of it may pick for a  conversation, whatever the price list offers. Only a DocSpace administrator may read it, and the call is  read-only. When the installation has no billing service or AI is not enabled for the portal, the answer is an  empty set instead of an error, which is indistinguishable from a portal that restricts nothing. An empty  `models` therefore means every model in `GET api/2.0/portal/payment/ai-prices` may be used. The set names the  barred models and not the allowed ones; replace it with `PUT api/2.0/portal/payment/ai-model/restrictions`.
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
        /// Returns the AI chat models that are barred on this portal - the ones no user of it may pick for a  conversation, whatever the price list offers. Only a DocSpace administrator may read it, and the call is  read-only. When the installation has no billing service or AI is not enabled for the portal, the answer is an  empty set instead of an error, which is indistinguishable from a portal that restricts nothing. An empty  `models` therefore means every model in `GET api/2.0/portal/payment/ai-prices` may be used. The set names the  barred models and not the allowed ones; replace it with `PUT api/2.0/portal/payment/ai-model/restrictions`.
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
        /// Returns the AI chat models that are barred on this portal - the ones no user of it may pick for a  conversation, whatever the price list offers. Only a DocSpace administrator may read it, and the call is  read-only. When the installation has no billing service or AI is not enabled for the portal, the answer is an  empty set instead of an error, which is indistinguishable from a portal that restricts nothing. An empty  `models` therefore means every model in `GET api/2.0/portal/payment/ai-prices` may be used. The set names the  barred models and not the allowed ones; replace it with `PUT api/2.0/portal/payment/ai-model/restrictions`.
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
        /// Returns the AI chat models that are barred on this portal - the ones no user of it may pick for a  conversation, whatever the price list offers. Only a DocSpace administrator may read it, and the call is  read-only. When the installation has no billing service or AI is not enabled for the portal, the answer is an  empty set instead of an error, which is indistinguishable from a portal that restricts nothing. An empty  `models` therefore means every model in `GET api/2.0/portal/payment/ai-prices` may be used. The set names the  barred models and not the allowed ones; replace it with `PUT api/2.0/portal/payment/ai-model/restrictions`.
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
        /// Reports in money how much of the portal's paid subscription period is still unused - the credit that  `POST api/2.0/portal/payment/subscription/movetowallet` would carry over to the wallet if the subscription  were ended now. The portal must have a billing customer and a plan in the paid state; a plan that is not paid  answers 402, and a paid plan without a subscription row gives 404. Only the payer - the portal user whose  e-mail is the billing customer's e-mail - may read it, and the call is read-only. The answer states the total  cost of the current period with its currency, the start and the end of that period in UTC, the moment the  unused part is measured up to, the days already elapsed, and the remaining balance both in the subscription  currency and converted to the wallet currency. Every figure is computed for the instant of the request, so it  changes between calls.
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
        /// Reports in money how much of the portal's paid subscription period is still unused - the credit that  `POST api/2.0/portal/payment/subscription/movetowallet` would carry over to the wallet if the subscription  were ended now. The portal must have a billing customer and a plan in the paid state; a plan that is not paid  answers 402, and a paid plan without a subscription row gives 404. Only the payer - the portal user whose  e-mail is the billing customer's e-mail - may read it, and the call is read-only. The answer states the total  cost of the current period with its currency, the start and the end of that period in UTC, the moment the  unused part is measured up to, the days already elapsed, and the remaining balance both in the subscription  currency and converted to the wallet currency. Every figure is computed for the instant of the request, so it  changes between calls.
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
        /// Reports in money how much of the portal's paid subscription period is still unused - the credit that  `POST api/2.0/portal/payment/subscription/movetowallet` would carry over to the wallet if the subscription  were ended now. The portal must have a billing customer and a plan in the paid state; a plan that is not paid  answers 402, and a paid plan without a subscription row gives 404. Only the payer - the portal user whose  e-mail is the billing customer's e-mail - may read it, and the call is read-only. The answer states the total  cost of the current period with its currency, the start and the end of that period in UTC, the moment the  unused part is measured up to, the days already elapsed, and the remaining balance both in the subscription  currency and converted to the wallet currency. Every figure is computed for the instant of the request, so it  changes between calls.
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
        /// Reports in money how much of the portal's paid subscription period is still unused - the credit that  `POST api/2.0/portal/payment/subscription/movetowallet` would carry over to the wallet if the subscription  were ended now. The portal must have a billing customer and a plan in the paid state; a plan that is not paid  answers 402, and a paid plan without a subscription row gives 404. Only the payer - the portal user whose  e-mail is the billing customer's e-mail - may read it, and the call is read-only. The answer states the total  cost of the current period with its currency, the start and the end of that period in UTC, the moment the  unused part is measured up to, the days already elapsed, and the remaining balance both in the subscription  currency and converted to the wallet currency. Every figure is computed for the instant of the request, so it  changes between calls.
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
        /// Get the wallet service settings
        /// </summary>
        /// <remarks>
        /// Returns which wallet services an administrator has switched on for this portal by hand, as opposed to the ones  its plan pays for. Only a DocSpace administrator may read it, an installation without a billing service  answers 403, no billing customer is needed, and the call is read-only. `enabledServices` holds the names of  those services and is empty when none was switched on. This is the stored setting and not the state of the  portal: a service the plan brings with it is active without appearing here, so the honest answer to what is  running is `GET api/2.0/portal/payment/activeservices`. One entry is changed with  `POST api/2.0/portal/payment/servicestate`.
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
        /// Get the wallet service settings
        /// </summary>
        /// <remarks>
        /// Returns which wallet services an administrator has switched on for this portal by hand, as opposed to the ones  its plan pays for. Only a DocSpace administrator may read it, an installation without a billing service  answers 403, no billing customer is needed, and the call is read-only. `enabledServices` holds the names of  those services and is empty when none was switched on. This is the stored setting and not the state of the  portal: a service the plan brings with it is active without appearing here, so the honest answer to what is  running is `GET api/2.0/portal/payment/activeservices`. One entry is changed with  `POST api/2.0/portal/payment/servicestate`.
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
        /// Get the wallet service settings
        /// </summary>
        /// <remarks>
        /// Returns which wallet services an administrator has switched on for this portal by hand, as opposed to the ones  its plan pays for. Only a DocSpace administrator may read it, an installation without a billing service  answers 403, no billing customer is needed, and the call is read-only. `enabledServices` holds the names of  those services and is empty when none was switched on. This is the stored setting and not the state of the  portal: a service the plan brings with it is active without appearing here, so the honest answer to what is  running is `GET api/2.0/portal/payment/activeservices`. One entry is changed with  `POST api/2.0/portal/payment/servicestate`.
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
        /// Get the wallet service settings
        /// </summary>
        /// <remarks>
        /// Returns which wallet services an administrator has switched on for this portal by hand, as opposed to the ones  its plan pays for. Only a DocSpace administrator may read it, an installation without a billing service  answers 403, no billing customer is needed, and the call is read-only. `enabledServices` holds the names of  those services and is empty when none was switched on. This is the stored setting and not the state of the  portal: a service the plan brings with it is active without appearing here, so the honest answer to what is  running is `GET api/2.0/portal/payment/activeservices`. One entry is changed with  `POST api/2.0/portal/payment/servicestate`.
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
        /// Get the auto top-up settings
        /// </summary>
        /// <remarks>
        /// Returns the portal's automatic wallet top-up settings - whether it is on, the balance that triggers a  charge, the balance it is topped up to, and the currency both are expressed in. Any DocSpace  administrator may read them, and unlike the operation that changes them this one needs neither a  billing customer nor a configured billing service, so it answers on a portal that has never paid for  anything. It is read-only and changes nothing.  A portal that has never configured top-up gets the defaults rather than an empty result: `enabled` is  false, `currency` is null, and `minBalance` and `upToBalance` are 0. Those two zeros are outside the  ranges `POST api/2.0/portal/payment/topupsettings` accepts - 5 to 1000 and 6 to 5000 - so the answer  cannot be sent straight back to it; supply real values instead. `lastModified` is  `0001-01-01T00:00:00` until the settings are stored for the first time.  `lowBalanceThreshold` and `lowBalanceNotified` are maintained by the portal itself: they are reported  here, but ignored when the settings are written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-wallet-settings/">REST API Reference for GetTenantWalletSettings Operation</seealso>
        /// <returns>TenantWalletSettingsResponseWrapper</returns>
        public TenantWalletSettingsResponseWrapper GetTenantWalletSettings()
        {
            var localVarResponse = GetTenantWalletSettingsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the auto top-up settings
        /// </summary>
        /// <remarks>
        /// Returns the portal's automatic wallet top-up settings - whether it is on, the balance that triggers a  charge, the balance it is topped up to, and the currency both are expressed in. Any DocSpace  administrator may read them, and unlike the operation that changes them this one needs neither a  billing customer nor a configured billing service, so it answers on a portal that has never paid for  anything. It is read-only and changes nothing.  A portal that has never configured top-up gets the defaults rather than an empty result: `enabled` is  false, `currency` is null, and `minBalance` and `upToBalance` are 0. Those two zeros are outside the  ranges `POST api/2.0/portal/payment/topupsettings` accepts - 5 to 1000 and 6 to 5000 - so the answer  cannot be sent straight back to it; supply real values instead. `lastModified` is  `0001-01-01T00:00:00` until the settings are stored for the first time.  `lowBalanceThreshold` and `lowBalanceNotified` are maintained by the portal itself: they are reported  here, but ignored when the settings are written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-wallet-settings/">REST API Reference for GetTenantWalletSettings Operation</seealso>
        /// <returns>ApiResponse of TenantWalletSettingsResponseWrapper</returns>
        public ApiResponse<TenantWalletSettingsResponseWrapper> GetTenantWalletSettingsWithHttpInfo()
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
            var localVarResponse = Client.Get<TenantWalletSettingsResponseWrapper>("/api/2.0/portal/payment/topupsettings", localVarRequestOptions, Configuration);

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
        /// Get the auto top-up settings
        /// </summary>
        /// <remarks>
        /// Returns the portal's automatic wallet top-up settings - whether it is on, the balance that triggers a  charge, the balance it is topped up to, and the currency both are expressed in. Any DocSpace  administrator may read them, and unlike the operation that changes them this one needs neither a  billing customer nor a configured billing service, so it answers on a portal that has never paid for  anything. It is read-only and changes nothing.  A portal that has never configured top-up gets the defaults rather than an empty result: `enabled` is  false, `currency` is null, and `minBalance` and `upToBalance` are 0. Those two zeros are outside the  ranges `POST api/2.0/portal/payment/topupsettings` accepts - 5 to 1000 and 6 to 5000 - so the answer  cannot be sent straight back to it; supply real values instead. `lastModified` is  `0001-01-01T00:00:00` until the settings are stored for the first time.  `lowBalanceThreshold` and `lowBalanceNotified` are maintained by the portal itself: they are reported  here, but ignored when the settings are written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-wallet-settings/">REST API Reference for GetTenantWalletSettings Operation</seealso>
        /// <returns>Task of TenantWalletSettingsResponseWrapper</returns>
        public async Task<TenantWalletSettingsResponseWrapper> GetTenantWalletSettingsAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetTenantWalletSettingsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the auto top-up settings
        /// </summary>
        /// <remarks>
        /// Returns the portal's automatic wallet top-up settings - whether it is on, the balance that triggers a  charge, the balance it is topped up to, and the currency both are expressed in. Any DocSpace  administrator may read them, and unlike the operation that changes them this one needs neither a  billing customer nor a configured billing service, so it answers on a portal that has never paid for  anything. It is read-only and changes nothing.  A portal that has never configured top-up gets the defaults rather than an empty result: `enabled` is  false, `currency` is null, and `minBalance` and `upToBalance` are 0. Those two zeros are outside the  ranges `POST api/2.0/portal/payment/topupsettings` accepts - 5 to 1000 and 6 to 5000 - so the answer  cannot be sent straight back to it; supply real values instead. `lastModified` is  `0001-01-01T00:00:00` until the settings are stored for the first time.  `lowBalanceThreshold` and `lowBalanceNotified` are maintained by the portal itself: they are reported  here, but ignored when the settings are written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-wallet-settings/">REST API Reference for GetTenantWalletSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantWalletSettingsResponseWrapper)</returns>
        public async Task<ApiResponse<TenantWalletSettingsResponseWrapper>> GetTenantWalletSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<TenantWalletSettingsResponseWrapper>("/api/2.0/portal/payment/topupsettings", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

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
        /// Get a wallet service
        /// </summary>
        /// <remarks>
        /// Returns one wallet service by name, for a client that already knows which service it needs and does not want  the whole catalogue. `service` is the name of the service - `Storage`, `Backup`, `AITools`, `Admin`,  `DocsCloud`, `DocsCloudDevPack` or `AISearch` - and a name this installation does not sell answers 404.  Nothing has to be called first, the caller needs the permission to edit the portal settings, and the call is  read-only. The answer has the same shape as one item of `GET api/2.0/portal/payment/walletservices` - the  price of a unit, the unit, the limits the service grants and its service name - except that the variants of a  service are not grouped into `innerServices` here, because a single service is looked up directly. The price  is in the currency resolved for the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="service">The service to look up, given by its catalogue name. A service this installation does not sell answers 404,  and the whole catalogue is `GET api/2.0/portal/payment/walletservices`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-wallet-service/">REST API Reference for GetWalletService Operation</seealso>
        /// <returns>WalletServiceWrapper</returns>
        public WalletServiceWrapper GetWalletService(TenantWalletService service)
        {
            var localVarResponse = GetWalletServiceWithHttpInfo(service);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a wallet service
        /// </summary>
        /// <remarks>
        /// Returns one wallet service by name, for a client that already knows which service it needs and does not want  the whole catalogue. `service` is the name of the service - `Storage`, `Backup`, `AITools`, `Admin`,  `DocsCloud`, `DocsCloudDevPack` or `AISearch` - and a name this installation does not sell answers 404.  Nothing has to be called first, the caller needs the permission to edit the portal settings, and the call is  read-only. The answer has the same shape as one item of `GET api/2.0/portal/payment/walletservices` - the  price of a unit, the unit, the limits the service grants and its service name - except that the variants of a  service are not grouped into `innerServices` here, because a single service is looked up directly. The price  is in the currency resolved for the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="service">The service to look up, given by its catalogue name. A service this installation does not sell answers 404,  and the whole catalogue is `GET api/2.0/portal/payment/walletservices`.</param>
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
        /// Get a wallet service
        /// </summary>
        /// <remarks>
        /// Returns one wallet service by name, for a client that already knows which service it needs and does not want  the whole catalogue. `service` is the name of the service - `Storage`, `Backup`, `AITools`, `Admin`,  `DocsCloud`, `DocsCloudDevPack` or `AISearch` - and a name this installation does not sell answers 404.  Nothing has to be called first, the caller needs the permission to edit the portal settings, and the call is  read-only. The answer has the same shape as one item of `GET api/2.0/portal/payment/walletservices` - the  price of a unit, the unit, the limits the service grants and its service name - except that the variants of a  service are not grouped into `innerServices` here, because a single service is looked up directly. The price  is in the currency resolved for the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="service">The service to look up, given by its catalogue name. A service this installation does not sell answers 404,  and the whole catalogue is `GET api/2.0/portal/payment/walletservices`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-wallet-service/">REST API Reference for GetWalletService Operation</seealso>
        /// <returns>Task of WalletServiceWrapper</returns>
        public async Task<WalletServiceWrapper> GetWalletServiceAsync(TenantWalletService service, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetWalletServiceWithHttpInfoAsync(service, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a wallet service
        /// </summary>
        /// <remarks>
        /// Returns one wallet service by name, for a client that already knows which service it needs and does not want  the whole catalogue. `service` is the name of the service - `Storage`, `Backup`, `AITools`, `Admin`,  `DocsCloud`, `DocsCloudDevPack` or `AISearch` - and a name this installation does not sell answers 404.  Nothing has to be called first, the caller needs the permission to edit the portal settings, and the call is  read-only. The answer has the same shape as one item of `GET api/2.0/portal/payment/walletservices` - the  price of a unit, the unit, the limits the service grants and its service name - except that the variants of a  service are not grouped into `innerServices` here, because a single service is looked up directly. The price  is in the currency resolved for the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="service">The service to look up, given by its catalogue name. A service this installation does not sell answers 404,  and the whole catalogue is `GET api/2.0/portal/payment/walletservices`.</param>
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
        /// Lists every service the portal may pay for out of its wallet - extra administrators, disk storage, backup, AI  tools, AI search and DocsCloud - with the price of a unit, the unit it is sold in and whether the portal has  it switched on. Nothing has to be called first, the caller needs the permission to edit the portal settings,  and the call is read-only. Services that are variants of one another are folded together: the visible one  carries the rest in its `innerServices`, so a client renders one card per group. The AI services are left out  entirely when AI is not enabled for the portal. This is the catalogue and not the state of the portal - what  is actually running is `GET api/2.0/portal/payment/activeservices`, one service on its own is  `GET api/2.0/portal/payment/walletservice`, and switching one on or off is  `POST api/2.0/portal/payment/servicestate`.
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
        /// Lists every service the portal may pay for out of its wallet - extra administrators, disk storage, backup, AI  tools, AI search and DocsCloud - with the price of a unit, the unit it is sold in and whether the portal has  it switched on. Nothing has to be called first, the caller needs the permission to edit the portal settings,  and the call is read-only. Services that are variants of one another are folded together: the visible one  carries the rest in its `innerServices`, so a client renders one card per group. The AI services are left out  entirely when AI is not enabled for the portal. This is the catalogue and not the state of the portal - what  is actually running is `GET api/2.0/portal/payment/activeservices`, one service on its own is  `GET api/2.0/portal/payment/walletservice`, and switching one on or off is  `POST api/2.0/portal/payment/servicestate`.
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
        /// Lists every service the portal may pay for out of its wallet - extra administrators, disk storage, backup, AI  tools, AI search and DocsCloud - with the price of a unit, the unit it is sold in and whether the portal has  it switched on. Nothing has to be called first, the caller needs the permission to edit the portal settings,  and the call is read-only. Services that are variants of one another are folded together: the visible one  carries the rest in its `innerServices`, so a client renders one card per group. The AI services are left out  entirely when AI is not enabled for the portal. This is the catalogue and not the state of the portal - what  is actually running is `GET api/2.0/portal/payment/activeservices`, one service on its own is  `GET api/2.0/portal/payment/walletservice`, and switching one on or off is  `POST api/2.0/portal/payment/servicestate`.
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
        /// Lists every service the portal may pay for out of its wallet - extra administrators, disk storage, backup, AI  tools, AI search and DocsCloud - with the price of a unit, the unit it is sold in and whether the portal has  it switched on. Nothing has to be called first, the caller needs the permission to edit the portal settings,  and the call is read-only. Services that are variants of one another are folded together: the visible one  carries the rest in its `innerServices`, so a client renders one card per group. The AI services are left out  entirely when AI is not enabled for the portal. This is the catalogue and not the state of the portal - what  is actually running is `GET api/2.0/portal/payment/activeservices`, one service on its own is  `GET api/2.0/portal/payment/walletservice`, and switching one on or off is  `POST api/2.0/portal/payment/servicestate`.
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
        /// Move the subscription to the wallet
        /// </summary>
        /// <remarks>
        /// Ends the portal's paid subscription and moves it onto the wallet: the unused balance of the running period is  credited to the wallet, the wallet is topped up from the payment method on file if that credit does not cover  the purchase, and the requested number of administrators is then bought as a wallet service. The portal needs  a billing customer with a payment method set and a plan in the paid state, `quantity` has to name the  administrators wallet product, and the number asked for may not be below the administrators the portal already  has - read the credit that will be carried over from `GET api/2.0/portal/payment/subscription/balance` first.  Only the payer may call it. The call is mutating, spends money and cannot be undone: the subscription is ended  before the purchase is attempted, so a failure in the second half leaves the portal on the wallet with the  money credited but the administrators unbought, and a repeat would then buy them a second time. It is limited  to ten requests a minute per user by default. The result is `true` when the administrators were bought.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quantityRequestDto">The new size of the portal subscription. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-subscription-to-wallet/">REST API Reference for MoveSubscriptionToWallet Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper MoveSubscriptionToWallet(QuantityRequestDto? quantityRequestDto = default)
        {
            var localVarResponse = MoveSubscriptionToWalletWithHttpInfo(quantityRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Move the subscription to the wallet
        /// </summary>
        /// <remarks>
        /// Ends the portal's paid subscription and moves it onto the wallet: the unused balance of the running period is  credited to the wallet, the wallet is topped up from the payment method on file if that credit does not cover  the purchase, and the requested number of administrators is then bought as a wallet service. The portal needs  a billing customer with a payment method set and a plan in the paid state, `quantity` has to name the  administrators wallet product, and the number asked for may not be below the administrators the portal already  has - read the credit that will be carried over from `GET api/2.0/portal/payment/subscription/balance` first.  Only the payer may call it. The call is mutating, spends money and cannot be undone: the subscription is ended  before the purchase is attempted, so a failure in the second half leaves the portal on the wallet with the  money credited but the administrators unbought, and a repeat would then buy them a second time. It is limited  to ten requests a minute per user by default. The result is `true` when the administrators were bought.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quantityRequestDto">The new size of the portal subscription. (optional)</param>
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
        /// Move the subscription to the wallet
        /// </summary>
        /// <remarks>
        /// Ends the portal's paid subscription and moves it onto the wallet: the unused balance of the running period is  credited to the wallet, the wallet is topped up from the payment method on file if that credit does not cover  the purchase, and the requested number of administrators is then bought as a wallet service. The portal needs  a billing customer with a payment method set and a plan in the paid state, `quantity` has to name the  administrators wallet product, and the number asked for may not be below the administrators the portal already  has - read the credit that will be carried over from `GET api/2.0/portal/payment/subscription/balance` first.  Only the payer may call it. The call is mutating, spends money and cannot be undone: the subscription is ended  before the purchase is attempted, so a failure in the second half leaves the portal on the wallet with the  money credited but the administrators unbought, and a repeat would then buy them a second time. It is limited  to ten requests a minute per user by default. The result is `true` when the administrators were bought.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quantityRequestDto">The new size of the portal subscription. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-subscription-to-wallet/">REST API Reference for MoveSubscriptionToWallet Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async Task<BooleanWrapper> MoveSubscriptionToWalletAsync(QuantityRequestDto? quantityRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await MoveSubscriptionToWalletWithHttpInfoAsync(quantityRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Move the subscription to the wallet
        /// </summary>
        /// <remarks>
        /// Ends the portal's paid subscription and moves it onto the wallet: the unused balance of the running period is  credited to the wallet, the wallet is topped up from the payment method on file if that credit does not cover  the purchase, and the requested number of administrators is then bought as a wallet service. The portal needs  a billing customer with a payment method set and a plan in the paid state, `quantity` has to name the  administrators wallet product, and the number asked for may not be below the administrators the portal already  has - read the credit that will be carried over from `GET api/2.0/portal/payment/subscription/balance` first.  Only the payer may call it. The call is mutating, spends money and cannot be undone: the subscription is ended  before the purchase is attempted, so a failure in the second half leaves the portal on the wallet with the  money credited but the administrators unbought, and a repeat would then buy them a second time. It is limited  to ten requests a minute per user by default. The result is `true` when the administrators were bought.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quantityRequestDto">The new size of the portal subscription. (optional)</param>
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
        /// Contact the sales team
        /// </summary>
        /// <remarks>
        /// Sends the portal's message to the ONLYOFFICE sales team - the contact-sales form behind a request for a quote,  an invoice or a plan that cannot be bought online. `email` has to be a well-formed address and is where the  answer will go, while `userName` and `message` say who is asking and what for; all three are required and none  may be empty. Only a DocSpace administrator may call it. Nothing on the portal changes: no plan, no quota and  no payment is touched, a message is mailed out and the request is written to the portal audit trail. There is  no response body - status 200 means the message was handed to the mail service - and the call is not  idempotent, so a repeat sends a second message. It is limited to ten requests a minute per user by default and  answers 429 above that.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesRequestsDto">Who is writing to the ONLYOFFICE sales team, and what about. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-payment-request/">REST API Reference for SendPaymentRequest Operation</seealso>
        /// <returns></returns>
        public void SendPaymentRequest(SalesRequestsDto? salesRequestsDto = default)
        {
            SendPaymentRequestWithHttpInfo(salesRequestsDto);
        }

        /// <summary>
        /// Contact the sales team
        /// </summary>
        /// <remarks>
        /// Sends the portal's message to the ONLYOFFICE sales team - the contact-sales form behind a request for a quote,  an invoice or a plan that cannot be bought online. `email` has to be a well-formed address and is where the  answer will go, while `userName` and `message` say who is asking and what for; all three are required and none  may be empty. Only a DocSpace administrator may call it. Nothing on the portal changes: no plan, no quota and  no payment is touched, a message is mailed out and the request is written to the portal audit trail. There is  no response body - status 200 means the message was handed to the mail service - and the call is not  idempotent, so a repeat sends a second message. It is limited to ten requests a minute per user by default and  answers 429 above that.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesRequestsDto">Who is writing to the ONLYOFFICE sales team, and what about. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-payment-request/">REST API Reference for SendPaymentRequest Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> SendPaymentRequestWithHttpInfo(SalesRequestsDto? salesRequestsDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

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
        /// Contact the sales team
        /// </summary>
        /// <remarks>
        /// Sends the portal's message to the ONLYOFFICE sales team - the contact-sales form behind a request for a quote,  an invoice or a plan that cannot be bought online. `email` has to be a well-formed address and is where the  answer will go, while `userName` and `message` say who is asking and what for; all three are required and none  may be empty. Only a DocSpace administrator may call it. Nothing on the portal changes: no plan, no quota and  no payment is touched, a message is mailed out and the request is written to the portal audit trail. There is  no response body - status 200 means the message was handed to the mail service - and the call is not  idempotent, so a repeat sends a second message. It is limited to ten requests a minute per user by default and  answers 429 above that.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesRequestsDto">Who is writing to the ONLYOFFICE sales team, and what about. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-payment-request/">REST API Reference for SendPaymentRequest Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task SendPaymentRequestAsync(SalesRequestsDto? salesRequestsDto = default, CancellationToken cancellationToken = default)
        {
            await SendPaymentRequestWithHttpInfoAsync(salesRequestsDto, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Contact the sales team
        /// </summary>
        /// <remarks>
        /// Sends the portal's message to the ONLYOFFICE sales team - the contact-sales form behind a request for a quote,  an invoice or a plan that cannot be bought online. `email` has to be a well-formed address and is where the  answer will go, while `userName` and `message` say who is asking and what for; all three are required and none  may be empty. Only a DocSpace administrator may call it. Nothing on the portal changes: no plan, no quota and  no payment is touched, a message is mailed out and the request is written to the portal audit trail. There is  no response body - status 200 means the message was handed to the mail service - and the call is not  idempotent, so a repeat sends a second message. It is limited to ten requests a minute per user by default and  answers 429 above that.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salesRequestsDto">Who is writing to the ONLYOFFICE sales team, and what about. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-payment-request/">REST API Reference for SendPaymentRequest Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> SendPaymentRequestWithHttpInfoAsync(SalesRequestsDto? salesRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


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
        /// Replaces the whole set of AI chat models barred on this portal: the body is the complete set that is to hold,  so adding one restriction means sending the new model together with the ones already restricted, lifting one  means leaving it out, and an empty set lifts them all. Read the current set from  `GET api/2.0/portal/payment/ai-model/restrictions` and the model identifiers from  `GET api/2.0/portal/payment/ai-prices` before calling. The installation needs a billing service and the AI  gateway configured, the portal needs a billing customer, and the caller needs the permission to edit the  portal settings as well as DocSpace administrator rights. The call is mutating and idempotent - sending the  same set twice leaves the same state - and it is written to the portal audit trail. It takes effect on the  next AI request, so a conversation already open on a model that has just been barred cannot go on with it. The  stored set comes back in the answer.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setRestrictedAiModelsRequestDto">The complete set of AI chat models that are to be barred on the portal. (optional)</param>
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
        /// Replaces the whole set of AI chat models barred on this portal: the body is the complete set that is to hold,  so adding one restriction means sending the new model together with the ones already restricted, lifting one  means leaving it out, and an empty set lifts them all. Read the current set from  `GET api/2.0/portal/payment/ai-model/restrictions` and the model identifiers from  `GET api/2.0/portal/payment/ai-prices` before calling. The installation needs a billing service and the AI  gateway configured, the portal needs a billing customer, and the caller needs the permission to edit the  portal settings as well as DocSpace administrator rights. The call is mutating and idempotent - sending the  same set twice leaves the same state - and it is written to the portal audit trail. It takes effect on the  next AI request, so a conversation already open on a model that has just been barred cannot go on with it. The  stored set comes back in the answer.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setRestrictedAiModelsRequestDto">The complete set of AI chat models that are to be barred on the portal. (optional)</param>
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
        /// Replaces the whole set of AI chat models barred on this portal: the body is the complete set that is to hold,  so adding one restriction means sending the new model together with the ones already restricted, lifting one  means leaving it out, and an empty set lifts them all. Read the current set from  `GET api/2.0/portal/payment/ai-model/restrictions` and the model identifiers from  `GET api/2.0/portal/payment/ai-prices` before calling. The installation needs a billing service and the AI  gateway configured, the portal needs a billing customer, and the caller needs the permission to edit the  portal settings as well as DocSpace administrator rights. The call is mutating and idempotent - sending the  same set twice leaves the same state - and it is written to the portal audit trail. It takes effect on the  next AI request, so a conversation already open on a model that has just been barred cannot go on with it. The  stored set comes back in the answer.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setRestrictedAiModelsRequestDto">The complete set of AI chat models that are to be barred on the portal. (optional)</param>
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
        /// Replaces the whole set of AI chat models barred on this portal: the body is the complete set that is to hold,  so adding one restriction means sending the new model together with the ones already restricted, lifting one  means leaving it out, and an empty set lifts them all. Read the current set from  `GET api/2.0/portal/payment/ai-model/restrictions` and the model identifiers from  `GET api/2.0/portal/payment/ai-prices` before calling. The installation needs a billing service and the AI  gateway configured, the portal needs a billing customer, and the caller needs the permission to edit the  portal settings as well as DocSpace administrator rights. The call is mutating and idempotent - sending the  same set twice leaves the same state - and it is written to the portal audit trail. It takes effect on the  next AI request, so a conversation already open on a model that has just been barred cannot go on with it. The  stored set comes back in the answer.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setRestrictedAiModelsRequestDto">The complete set of AI chat models that are to be barred on the portal. (optional)</param>
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
        /// Set the auto top-up settings
        /// </summary>
        /// <remarks>
        /// Switches the portal's automatic wallet top-up on or off and sets its thresholds: while it is on, the payment  method on file is charged whenever the wallet balance falls below `minBalance`, enough to bring it up to  `upToBalance`, in `currency`. The portal needs a billing customer whose wallet balance exists - a portal that  has never had one answers 404, so top the wallet up once with `POST api/2.0/portal/payment/deposit` first -  and only the payer may change the settings. The body replaces the stored settings as a whole and an omitted  body resets them to the defaults; `minBalance` is accepted between 5 and 1000 and `upToBalance` between 6 and  5000, while `lowBalanceThreshold` and `lowBalanceNotified` are ignored on the way in and kept as the portal  had them. The call is mutating and idempotent, it charges nothing by itself, it is written to the portal audit  trail, and switching the top-up on also re-arms the low-balance warning. The settings as they were stored come  back in the answer.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantWalletSettingsWrapper">The wrapper for the tenant wallet settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tenant-wallet-settings/">REST API Reference for SetTenantWalletSettings Operation</seealso>
        /// <returns>TenantWalletSettingsResponseWrapper</returns>
        public TenantWalletSettingsResponseWrapper SetTenantWalletSettings(TenantWalletSettingsWrapper? tenantWalletSettingsWrapper = default)
        {
            var localVarResponse = SetTenantWalletSettingsWithHttpInfo(tenantWalletSettingsWrapper);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set the auto top-up settings
        /// </summary>
        /// <remarks>
        /// Switches the portal's automatic wallet top-up on or off and sets its thresholds: while it is on, the payment  method on file is charged whenever the wallet balance falls below `minBalance`, enough to bring it up to  `upToBalance`, in `currency`. The portal needs a billing customer whose wallet balance exists - a portal that  has never had one answers 404, so top the wallet up once with `POST api/2.0/portal/payment/deposit` first -  and only the payer may change the settings. The body replaces the stored settings as a whole and an omitted  body resets them to the defaults; `minBalance` is accepted between 5 and 1000 and `upToBalance` between 6 and  5000, while `lowBalanceThreshold` and `lowBalanceNotified` are ignored on the way in and kept as the portal  had them. The call is mutating and idempotent, it charges nothing by itself, it is written to the portal audit  trail, and switching the top-up on also re-arms the low-balance warning. The settings as they were stored come  back in the answer.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantWalletSettingsWrapper">The wrapper for the tenant wallet settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tenant-wallet-settings/">REST API Reference for SetTenantWalletSettings Operation</seealso>
        /// <returns>ApiResponse of TenantWalletSettingsResponseWrapper</returns>
        public ApiResponse<TenantWalletSettingsResponseWrapper> SetTenantWalletSettingsWithHttpInfo(TenantWalletSettingsWrapper? tenantWalletSettingsWrapper = default)
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
            var localVarResponse = Client.Post<TenantWalletSettingsResponseWrapper>("/api/2.0/portal/payment/topupsettings", localVarRequestOptions, Configuration);

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
        /// Set the auto top-up settings
        /// </summary>
        /// <remarks>
        /// Switches the portal's automatic wallet top-up on or off and sets its thresholds: while it is on, the payment  method on file is charged whenever the wallet balance falls below `minBalance`, enough to bring it up to  `upToBalance`, in `currency`. The portal needs a billing customer whose wallet balance exists - a portal that  has never had one answers 404, so top the wallet up once with `POST api/2.0/portal/payment/deposit` first -  and only the payer may change the settings. The body replaces the stored settings as a whole and an omitted  body resets them to the defaults; `minBalance` is accepted between 5 and 1000 and `upToBalance` between 6 and  5000, while `lowBalanceThreshold` and `lowBalanceNotified` are ignored on the way in and kept as the portal  had them. The call is mutating and idempotent, it charges nothing by itself, it is written to the portal audit  trail, and switching the top-up on also re-arms the low-balance warning. The settings as they were stored come  back in the answer.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantWalletSettingsWrapper">The wrapper for the tenant wallet settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tenant-wallet-settings/">REST API Reference for SetTenantWalletSettings Operation</seealso>
        /// <returns>Task of TenantWalletSettingsResponseWrapper</returns>
        public async Task<TenantWalletSettingsResponseWrapper> SetTenantWalletSettingsAsync(TenantWalletSettingsWrapper? tenantWalletSettingsWrapper = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetTenantWalletSettingsWithHttpInfoAsync(tenantWalletSettingsWrapper, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set the auto top-up settings
        /// </summary>
        /// <remarks>
        /// Switches the portal's automatic wallet top-up on or off and sets its thresholds: while it is on, the payment  method on file is charged whenever the wallet balance falls below `minBalance`, enough to bring it up to  `upToBalance`, in `currency`. The portal needs a billing customer whose wallet balance exists - a portal that  has never had one answers 404, so top the wallet up once with `POST api/2.0/portal/payment/deposit` first -  and only the payer may change the settings. The body replaces the stored settings as a whole and an omitted  body resets them to the defaults; `minBalance` is accepted between 5 and 1000 and `upToBalance` between 6 and  5000, while `lowBalanceThreshold` and `lowBalanceNotified` are ignored on the way in and kept as the portal  had them. The call is mutating and idempotent, it charges nothing by itself, it is written to the portal audit  trail, and switching the top-up on also re-arms the low-balance warning. The settings as they were stored come  back in the answer.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantWalletSettingsWrapper">The wrapper for the tenant wallet settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tenant-wallet-settings/">REST API Reference for SetTenantWalletSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantWalletSettingsResponseWrapper)</returns>
        public async Task<ApiResponse<TenantWalletSettingsResponseWrapper>> SetTenantWalletSettingsWithHttpInfoAsync(TenantWalletSettingsWrapper? tenantWalletSettingsWrapper = default, CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.PostAsync<TenantWalletSettingsResponseWrapper>("/api/2.0/portal/payment/topupsettings", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

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
        /// Terminate the monthly usage report
        /// </summary>
        /// <remarks>
        /// Stops the `xlsx` monthly usage report this user has running and drops its task, for a report that was started  for the wrong period or is no longer wanted. The portal needs a billing customer and the caller has to be a  DocSpace administrator. The stop is asked of the worker that builds the file rather than done here, so  `GET api/2.0/portal/payment/customer/usage/monthly/report` can still answer for a moment afterwards. The call  is safe to repeat and does nothing at all when this user has no such report running: there is no response  body, and status 200 says the stop was requested, not that a report was really stopped. It leaves the  operations and service usage reports alone, and a report that had already finished keeps its file in My  documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-monthly-usage-report/">REST API Reference for TerminateCustomerMonthlyUsageReport Operation</seealso>
        /// <returns></returns>
        public void TerminateCustomerMonthlyUsageReport()
        {
            TerminateCustomerMonthlyUsageReportWithHttpInfo();
        }

        /// <summary>
        /// Terminate the monthly usage report
        /// </summary>
        /// <remarks>
        /// Stops the `xlsx` monthly usage report this user has running and drops its task, for a report that was started  for the wrong period or is no longer wanted. The portal needs a billing customer and the caller has to be a  DocSpace administrator. The stop is asked of the worker that builds the file rather than done here, so  `GET api/2.0/portal/payment/customer/usage/monthly/report` can still answer for a moment afterwards. The call  is safe to repeat and does nothing at all when this user has no such report running: there is no response  body, and status 200 says the stop was requested, not that a report was really stopped. It leaves the  operations and service usage reports alone, and a report that had already finished keeps its file in My  documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-monthly-usage-report/">REST API Reference for TerminateCustomerMonthlyUsageReport Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> TerminateCustomerMonthlyUsageReportWithHttpInfo()
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
        /// Terminate the monthly usage report
        /// </summary>
        /// <remarks>
        /// Stops the `xlsx` monthly usage report this user has running and drops its task, for a report that was started  for the wrong period or is no longer wanted. The portal needs a billing customer and the caller has to be a  DocSpace administrator. The stop is asked of the worker that builds the file rather than done here, so  `GET api/2.0/portal/payment/customer/usage/monthly/report` can still answer for a moment afterwards. The call  is safe to repeat and does nothing at all when this user has no such report running: there is no response  body, and status 200 says the stop was requested, not that a report was really stopped. It leaves the  operations and service usage reports alone, and a report that had already finished keeps its file in My  documents.
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
        /// Terminate the monthly usage report
        /// </summary>
        /// <remarks>
        /// Stops the `xlsx` monthly usage report this user has running and drops its task, for a report that was started  for the wrong period or is no longer wanted. The portal needs a billing customer and the caller has to be a  DocSpace administrator. The stop is asked of the worker that builds the file rather than done here, so  `GET api/2.0/portal/payment/customer/usage/monthly/report` can still answer for a moment afterwards. The call  is safe to repeat and does nothing at all when this user has no such report running: there is no response  body, and status 200 says the stop was requested, not that a report was really stopped. It leaves the  operations and service usage reports alone, and a report that had already finished keeps its file in My  documents.
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
        /// Terminate the operations report
        /// </summary>
        /// <remarks>
        /// Stops the `xlsx` wallet operations report this user has running and drops its task, for a report that was  started with the wrong filters or is no longer wanted. The portal needs a billing customer and the caller has  to be a DocSpace administrator. The stop is asked of the worker that builds the file rather than done here, so  `GET api/2.0/portal/payment/customer/operationsreport` can still answer for a moment afterwards. The call is  safe to repeat and does nothing at all when this user has no report running: there is no response body, and  status 200 says the stop was requested, not that a report was really stopped. A report that had already  finished keeps its file in My documents - nothing is deleted from there.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-operations-report/">REST API Reference for TerminateCustomerOperationsReport Operation</seealso>
        /// <returns></returns>
        public void TerminateCustomerOperationsReport()
        {
            TerminateCustomerOperationsReportWithHttpInfo();
        }

        /// <summary>
        /// Terminate the operations report
        /// </summary>
        /// <remarks>
        /// Stops the `xlsx` wallet operations report this user has running and drops its task, for a report that was  started with the wrong filters or is no longer wanted. The portal needs a billing customer and the caller has  to be a DocSpace administrator. The stop is asked of the worker that builds the file rather than done here, so  `GET api/2.0/portal/payment/customer/operationsreport` can still answer for a moment afterwards. The call is  safe to repeat and does nothing at all when this user has no report running: there is no response body, and  status 200 says the stop was requested, not that a report was really stopped. A report that had already  finished keeps its file in My documents - nothing is deleted from there.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-operations-report/">REST API Reference for TerminateCustomerOperationsReport Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> TerminateCustomerOperationsReportWithHttpInfo()
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
        /// Terminate the operations report
        /// </summary>
        /// <remarks>
        /// Stops the `xlsx` wallet operations report this user has running and drops its task, for a report that was  started with the wrong filters or is no longer wanted. The portal needs a billing customer and the caller has  to be a DocSpace administrator. The stop is asked of the worker that builds the file rather than done here, so  `GET api/2.0/portal/payment/customer/operationsreport` can still answer for a moment afterwards. The call is  safe to repeat and does nothing at all when this user has no report running: there is no response body, and  status 200 says the stop was requested, not that a report was really stopped. A report that had already  finished keeps its file in My documents - nothing is deleted from there.
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
        /// Terminate the operations report
        /// </summary>
        /// <remarks>
        /// Stops the `xlsx` wallet operations report this user has running and drops its task, for a report that was  started with the wrong filters or is no longer wanted. The portal needs a billing customer and the caller has  to be a DocSpace administrator. The stop is asked of the worker that builds the file rather than done here, so  `GET api/2.0/portal/payment/customer/operationsreport` can still answer for a moment afterwards. The call is  safe to repeat and does nothing at all when this user has no report running: there is no response body, and  status 200 says the stop was requested, not that a report was really stopped. A report that had already  finished keeps its file in My documents - nothing is deleted from there.
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
        /// Terminate the service usage report
        /// </summary>
        /// <remarks>
        /// Stops the `xlsx` service usage report this user has running and drops its task, for a report that was started  with the wrong filters or is no longer wanted. The portal needs a billing customer and the caller has to be a  DocSpace administrator. The stop is asked of the worker that builds the file rather than done here, so  `GET api/2.0/portal/payment/customer/usage/report` can still answer for a moment afterwards. The call is safe  to repeat and does nothing at all when this user has no such report running: there is no response body, and  status 200 says the stop was requested, not that a report was really stopped. It leaves the operations and  monthly usage reports alone, and a report that had already finished keeps its file in My documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-service-usage-report/">REST API Reference for TerminateCustomerServiceUsageReport Operation</seealso>
        /// <returns></returns>
        public void TerminateCustomerServiceUsageReport()
        {
            TerminateCustomerServiceUsageReportWithHttpInfo();
        }

        /// <summary>
        /// Terminate the service usage report
        /// </summary>
        /// <remarks>
        /// Stops the `xlsx` service usage report this user has running and drops its task, for a report that was started  with the wrong filters or is no longer wanted. The portal needs a billing customer and the caller has to be a  DocSpace administrator. The stop is asked of the worker that builds the file rather than done here, so  `GET api/2.0/portal/payment/customer/usage/report` can still answer for a moment afterwards. The call is safe  to repeat and does nothing at all when this user has no such report running: there is no response body, and  status 200 says the stop was requested, not that a report was really stopped. It leaves the operations and  monthly usage reports alone, and a report that had already finished keeps its file in My documents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-customer-service-usage-report/">REST API Reference for TerminateCustomerServiceUsageReport Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> TerminateCustomerServiceUsageReportWithHttpInfo()
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
        /// Terminate the service usage report
        /// </summary>
        /// <remarks>
        /// Stops the `xlsx` service usage report this user has running and drops its task, for a report that was started  with the wrong filters or is no longer wanted. The portal needs a billing customer and the caller has to be a  DocSpace administrator. The stop is asked of the worker that builds the file rather than done here, so  `GET api/2.0/portal/payment/customer/usage/report` can still answer for a moment afterwards. The call is safe  to repeat and does nothing at all when this user has no such report running: there is no response body, and  status 200 says the stop was requested, not that a report was really stopped. It leaves the operations and  monthly usage reports alone, and a report that had already finished keeps its file in My documents.
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
        /// Terminate the service usage report
        /// </summary>
        /// <remarks>
        /// Stops the `xlsx` service usage report this user has running and drops its task, for a report that was started  with the wrong filters or is no longer wanted. The portal needs a billing customer and the caller has to be a  DocSpace administrator. The stop is asked of the worker that builds the file rather than done here, so  `GET api/2.0/portal/payment/customer/usage/report` can still answer for a moment afterwards. The call is safe  to repeat and does nothing at all when this user has no such report running: there is no response body, and  status 200 says the stop was requested, not that a report was really stopped. It leaves the operations and  monthly usage reports alone, and a report that had already finished keeps its file in My documents.
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
        /// Top up the wallet
        /// </summary>
        /// <remarks>
        /// Charges the payment method on file and adds the amount to the portal's wallet, the balance every wallet  service is paid from. The portal needs a billing customer with a payment method set - attach one with  `GET api/2.0/portal/payment/checkoutsetupurl` - `currency` has to be one of the accounting currencies this  installation supports, and `amount` is a whole number of currency units between 1 and 999999. Only the payer  may call it. The call takes money and is not idempotent in any way: two identical requests charge twice, so a  client must not retry it blindly after a timeout, and it is limited to ten requests a minute per user by  default. A successful top-up pushes the new balance to the portal clients over their socket connection and  re-arms the low-balance notification. The result is `true` when the payment provider accepted the charge; read  the resulting balance back from `GET api/2.0/portal/payment/customer/balance`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topUpDepositRequestDto">How much money is charged to the payment method on file and added to the portal wallet. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/top-up-deposit/">REST API Reference for TopUpDeposit Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper TopUpDeposit(TopUpDepositRequestDto? topUpDepositRequestDto = default)
        {
            var localVarResponse = TopUpDepositWithHttpInfo(topUpDepositRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Top up the wallet
        /// </summary>
        /// <remarks>
        /// Charges the payment method on file and adds the amount to the portal's wallet, the balance every wallet  service is paid from. The portal needs a billing customer with a payment method set - attach one with  `GET api/2.0/portal/payment/checkoutsetupurl` - `currency` has to be one of the accounting currencies this  installation supports, and `amount` is a whole number of currency units between 1 and 999999. Only the payer  may call it. The call takes money and is not idempotent in any way: two identical requests charge twice, so a  client must not retry it blindly after a timeout, and it is limited to ten requests a minute per user by  default. A successful top-up pushes the new balance to the portal clients over their socket connection and  re-arms the low-balance notification. The result is `true` when the payment provider accepted the charge; read  the resulting balance back from `GET api/2.0/portal/payment/customer/balance`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topUpDepositRequestDto">How much money is charged to the payment method on file and added to the portal wallet. (optional)</param>
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
        /// Top up the wallet
        /// </summary>
        /// <remarks>
        /// Charges the payment method on file and adds the amount to the portal's wallet, the balance every wallet  service is paid from. The portal needs a billing customer with a payment method set - attach one with  `GET api/2.0/portal/payment/checkoutsetupurl` - `currency` has to be one of the accounting currencies this  installation supports, and `amount` is a whole number of currency units between 1 and 999999. Only the payer  may call it. The call takes money and is not idempotent in any way: two identical requests charge twice, so a  client must not retry it blindly after a timeout, and it is limited to ten requests a minute per user by  default. A successful top-up pushes the new balance to the portal clients over their socket connection and  re-arms the low-balance notification. The result is `true` when the payment provider accepted the charge; read  the resulting balance back from `GET api/2.0/portal/payment/customer/balance`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topUpDepositRequestDto">How much money is charged to the payment method on file and added to the portal wallet. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/top-up-deposit/">REST API Reference for TopUpDeposit Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async Task<BooleanWrapper> TopUpDepositAsync(TopUpDepositRequestDto? topUpDepositRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await TopUpDepositWithHttpInfoAsync(topUpDepositRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Top up the wallet
        /// </summary>
        /// <remarks>
        /// Charges the payment method on file and adds the amount to the portal's wallet, the balance every wallet  service is paid from. The portal needs a billing customer with a payment method set - attach one with  `GET api/2.0/portal/payment/checkoutsetupurl` - `currency` has to be one of the accounting currencies this  installation supports, and `amount` is a whole number of currency units between 1 and 999999. Only the payer  may call it. The call takes money and is not idempotent in any way: two identical requests charge twice, so a  client must not retry it blindly after a timeout, and it is limited to ten requests a minute per user by  default. A successful top-up pushes the new balance to the portal clients over their socket connection and  re-arms the low-balance notification. The result is `true` when the payment provider accepted the charge; read  the resulting balance back from `GET api/2.0/portal/payment/customer/balance`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topUpDepositRequestDto">How much money is charged to the payment method on file and added to the portal wallet. (optional)</param>
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
        /// Change the subscription quantity
        /// </summary>
        /// <remarks>
        /// Changes how many units of the plan the portal is paying for - the number of administrators it covers - and  lets the payment provider bill the difference against the payment method already on file. The portal must have  a billing customer and a plan bought through `PUT api/2.0/portal/payment/url`, and while the portal is on a  priced plan the product name in `quantity` has to be that same plan, which `GET api/2.0/portal/payment/quota`  reports, because a subscription is changed here and not swapped. Only the payer - the portal user whose e-mail  is the billing customer's e-mail - may call it. The call is mutating and charges money, and it is guarded  against a double submission: once the new quantity is in effect, repeating the same request fails with 400  because that quantity is already set. The result is `true` when the provider accepted the change and `false`  when it declined it without an error. Exactly one product per call is accepted, the operation is limited to  ten requests a minute per user by default and answers 429 above that, and wallet services are not bought here  - use `PUT api/2.0/portal/payment/updatewallet` for those.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quantityRequestDto">The new size of the portal subscription. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-payment/">REST API Reference for UpdatePayment Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper UpdatePayment(QuantityRequestDto? quantityRequestDto = default)
        {
            var localVarResponse = UpdatePaymentWithHttpInfo(quantityRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change the subscription quantity
        /// </summary>
        /// <remarks>
        /// Changes how many units of the plan the portal is paying for - the number of administrators it covers - and  lets the payment provider bill the difference against the payment method already on file. The portal must have  a billing customer and a plan bought through `PUT api/2.0/portal/payment/url`, and while the portal is on a  priced plan the product name in `quantity` has to be that same plan, which `GET api/2.0/portal/payment/quota`  reports, because a subscription is changed here and not swapped. Only the payer - the portal user whose e-mail  is the billing customer's e-mail - may call it. The call is mutating and charges money, and it is guarded  against a double submission: once the new quantity is in effect, repeating the same request fails with 400  because that quantity is already set. The result is `true` when the provider accepted the change and `false`  when it declined it without an error. Exactly one product per call is accepted, the operation is limited to  ten requests a minute per user by default and answers 429 above that, and wallet services are not bought here  - use `PUT api/2.0/portal/payment/updatewallet` for those.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quantityRequestDto">The new size of the portal subscription. (optional)</param>
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
        /// Change the subscription quantity
        /// </summary>
        /// <remarks>
        /// Changes how many units of the plan the portal is paying for - the number of administrators it covers - and  lets the payment provider bill the difference against the payment method already on file. The portal must have  a billing customer and a plan bought through `PUT api/2.0/portal/payment/url`, and while the portal is on a  priced plan the product name in `quantity` has to be that same plan, which `GET api/2.0/portal/payment/quota`  reports, because a subscription is changed here and not swapped. Only the payer - the portal user whose e-mail  is the billing customer's e-mail - may call it. The call is mutating and charges money, and it is guarded  against a double submission: once the new quantity is in effect, repeating the same request fails with 400  because that quantity is already set. The result is `true` when the provider accepted the change and `false`  when it declined it without an error. Exactly one product per call is accepted, the operation is limited to  ten requests a minute per user by default and answers 429 above that, and wallet services are not bought here  - use `PUT api/2.0/portal/payment/updatewallet` for those.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quantityRequestDto">The new size of the portal subscription. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-payment/">REST API Reference for UpdatePayment Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async Task<BooleanWrapper> UpdatePaymentAsync(QuantityRequestDto? quantityRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UpdatePaymentWithHttpInfoAsync(quantityRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change the subscription quantity
        /// </summary>
        /// <remarks>
        /// Changes how many units of the plan the portal is paying for - the number of administrators it covers - and  lets the payment provider bill the difference against the payment method already on file. The portal must have  a billing customer and a plan bought through `PUT api/2.0/portal/payment/url`, and while the portal is on a  priced plan the product name in `quantity` has to be that same plan, which `GET api/2.0/portal/payment/quota`  reports, because a subscription is changed here and not swapped. Only the payer - the portal user whose e-mail  is the billing customer's e-mail - may call it. The call is mutating and charges money, and it is guarded  against a double submission: once the new quantity is in effect, repeating the same request fails with 400  because that quantity is already set. The result is `true` when the provider accepted the change and `false`  when it declined it without an error. Exactly one product per call is accepted, the operation is limited to  ten requests a minute per user by default and answers 429 above that, and wallet services are not bought here  - use `PUT api/2.0/portal/payment/updatewallet` for those.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quantityRequestDto">The new size of the portal subscription. (optional)</param>
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
        /// Change a wallet service quantity
        /// </summary>
        /// <remarks>
        /// Buys more units of a wallet service - extra administrators, disk storage, backup, AI tools, AI search or  DocsCloud - or writes down the quantity that service will have after the next renewal, depending on  `productQuantityType`. With `Add` (1) the units are bought at once and paid out of the portal wallet, so the  wallet needs a sub-account in the accounting currency and enough money on it; with `Set` (0) nothing is  charged now and the quantity only takes effect in the next period, where an empty or zero quantity cancels a  change scheduled earlier. `Renew` and `Sub` are not accepted here. The portal needs a billing customer and the  caller has to be a DocSpace administrator; a service that is an add-on to the plan also needs the plan itself  to be paid, otherwise the answer is 402. Minimum quantities apply - disk storage starts at 100 units, the  DocsCloud developer pack at 10, and the administrators may not be fewer than the portal already has - and in  the `Add` form they are checked only while the portal does not hold that service yet. Asking for the DocsCloud  plan in the `Set` form while the developer pack is active schedules the reversion to it at the next period,  while the upgrade in the other direction is not done here at all: use  `POST api/2.0/settings/docscloud/switchtodevpack`. The result is `true` when the change was accepted; the call  is mutating, spends money in its `Add` form and is limited to ten requests a minute per user by default. Price  the same purchase without paying for it with `PUT api/2.0/portal/payment/calculatewallet`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The wallet service being bought or scheduled, and the way its quantity is applied. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-wallet-payment/">REST API Reference for UpdateWalletPayment Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper UpdateWalletPayment(WalletQuantityRequestDto? walletQuantityRequestDto = default)
        {
            var localVarResponse = UpdateWalletPaymentWithHttpInfo(walletQuantityRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change a wallet service quantity
        /// </summary>
        /// <remarks>
        /// Buys more units of a wallet service - extra administrators, disk storage, backup, AI tools, AI search or  DocsCloud - or writes down the quantity that service will have after the next renewal, depending on  `productQuantityType`. With `Add` (1) the units are bought at once and paid out of the portal wallet, so the  wallet needs a sub-account in the accounting currency and enough money on it; with `Set` (0) nothing is  charged now and the quantity only takes effect in the next period, where an empty or zero quantity cancels a  change scheduled earlier. `Renew` and `Sub` are not accepted here. The portal needs a billing customer and the  caller has to be a DocSpace administrator; a service that is an add-on to the plan also needs the plan itself  to be paid, otherwise the answer is 402. Minimum quantities apply - disk storage starts at 100 units, the  DocsCloud developer pack at 10, and the administrators may not be fewer than the portal already has - and in  the `Add` form they are checked only while the portal does not hold that service yet. Asking for the DocsCloud  plan in the `Set` form while the developer pack is active schedules the reversion to it at the next period,  while the upgrade in the other direction is not done here at all: use  `POST api/2.0/settings/docscloud/switchtodevpack`. The result is `true` when the change was accepted; the call  is mutating, spends money in its `Add` form and is limited to ten requests a minute per user by default. Price  the same purchase without paying for it with `PUT api/2.0/portal/payment/calculatewallet`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The wallet service being bought or scheduled, and the way its quantity is applied. (optional)</param>
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
        /// Change a wallet service quantity
        /// </summary>
        /// <remarks>
        /// Buys more units of a wallet service - extra administrators, disk storage, backup, AI tools, AI search or  DocsCloud - or writes down the quantity that service will have after the next renewal, depending on  `productQuantityType`. With `Add` (1) the units are bought at once and paid out of the portal wallet, so the  wallet needs a sub-account in the accounting currency and enough money on it; with `Set` (0) nothing is  charged now and the quantity only takes effect in the next period, where an empty or zero quantity cancels a  change scheduled earlier. `Renew` and `Sub` are not accepted here. The portal needs a billing customer and the  caller has to be a DocSpace administrator; a service that is an add-on to the plan also needs the plan itself  to be paid, otherwise the answer is 402. Minimum quantities apply - disk storage starts at 100 units, the  DocsCloud developer pack at 10, and the administrators may not be fewer than the portal already has - and in  the `Add` form they are checked only while the portal does not hold that service yet. Asking for the DocsCloud  plan in the `Set` form while the developer pack is active schedules the reversion to it at the next period,  while the upgrade in the other direction is not done here at all: use  `POST api/2.0/settings/docscloud/switchtodevpack`. The result is `true` when the change was accepted; the call  is mutating, spends money in its `Add` form and is limited to ten requests a minute per user by default. Price  the same purchase without paying for it with `PUT api/2.0/portal/payment/calculatewallet`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The wallet service being bought or scheduled, and the way its quantity is applied. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-wallet-payment/">REST API Reference for UpdateWalletPayment Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async Task<BooleanWrapper> UpdateWalletPaymentAsync(WalletQuantityRequestDto? walletQuantityRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UpdateWalletPaymentWithHttpInfoAsync(walletQuantityRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change a wallet service quantity
        /// </summary>
        /// <remarks>
        /// Buys more units of a wallet service - extra administrators, disk storage, backup, AI tools, AI search or  DocsCloud - or writes down the quantity that service will have after the next renewal, depending on  `productQuantityType`. With `Add` (1) the units are bought at once and paid out of the portal wallet, so the  wallet needs a sub-account in the accounting currency and enough money on it; with `Set` (0) nothing is  charged now and the quantity only takes effect in the next period, where an empty or zero quantity cancels a  change scheduled earlier. `Renew` and `Sub` are not accepted here. The portal needs a billing customer and the  caller has to be a DocSpace administrator; a service that is an add-on to the plan also needs the plan itself  to be paid, otherwise the answer is 402. Minimum quantities apply - disk storage starts at 100 units, the  DocsCloud developer pack at 10, and the administrators may not be fewer than the portal already has - and in  the `Add` form they are checked only while the portal does not hold that service yet. Asking for the DocsCloud  plan in the `Set` form while the developer pack is active schedules the reversion to it at the next period,  while the upgrade in the other direction is not done here at all: use  `POST api/2.0/settings/docscloud/switchtodevpack`. The result is `true` when the change was accepted; the call  is mutating, spends money in its `Add` form and is limited to ten requests a minute per user by default. Price  the same purchase without paying for it with `PUT api/2.0/portal/payment/calculatewallet`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletQuantityRequestDto">The wallet service being bought or scheduled, and the way its quantity is applied. (optional)</param>
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
